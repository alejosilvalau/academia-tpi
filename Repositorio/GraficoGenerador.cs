using System.Data;
using SkiaSharp;

namespace Repositorio
{
    public static class GraficoGenerador
    {
        private const int Ancho = 720;
        private const int Alto = 360;

        private static readonly SKColor ColorAprobados = new(0x4C, 0xAF, 0x50);
        private static readonly SKColor ColorRegulares = new(0xFF, 0xC1, 0x07);
        private static readonly SKColor ColorSinNota = new(0xEF, 0x5C, 0x52);

        public static byte[] BarrasRendimientoDocente(DataTable tabla)
        {
            using var surface = SKSurface.Create(new SKImageInfo(Ancho, Alto));
            var canvas = surface.Canvas;
            canvas.Clear(SKColors.White);

            using var tituloFont = new SKPaint
            {
                Color = SKColors.DarkSlateGray,
                IsAntialias = true,
                Typeface = SKTypeface.FromFamilyName("Segoe UI", SKFontStyleWeight.Bold, SKFontStyleWidth.Normal, SKFontStyleSlant.Upright),
                TextSize = 18
            };
            using var etiquetaFont = new SKPaint
            {
                Color = SKColors.DarkSlateGray,
                IsAntialias = true,
                Typeface = SKTypeface.FromFamilyName("Segoe UI", SKFontStyleWeight.Normal, SKFontStyleWidth.Normal, SKFontStyleSlant.Upright),
                TextSize = 10
            };
            using var valorFont = new SKPaint
            {
                Color = SKColors.Black,
                IsAntialias = true,
                Typeface = SKTypeface.FromFamilyName("Segoe UI", SKFontStyleWeight.Normal, SKFontStyleWidth.Normal, SKFontStyleSlant.Upright),
                TextSize = 10
            };
            using var ejePaint = new SKPaint { Color = new SKColor(0xCC, 0xCC, 0xCC), StrokeWidth = 1, IsAntialias = true };
            using var legendFont = new SKPaint
            {
                Color = SKColors.DarkSlateGray,
                IsAntialias = true,
                Typeface = SKTypeface.FromFamilyName("Segoe UI", SKFontStyleWeight.Normal, SKFontStyleWidth.Normal, SKFontStyleSlant.Upright),
                TextSize = 11
            };

            canvas.DrawText("Condiciones por curso", 16, 26, tituloFont);

            var leyendas = new[] { ("Aprobados", ColorAprobados), ("Regulares", ColorRegulares), ("Sin nota", ColorSinNota) };
            int lx = Ancho - 200;
            for (int i = 0; i < leyendas.Length; i++)
            {
                using var box = new SKPaint { Color = leyendas[i].Item2, IsAntialias = true };
                canvas.DrawRect(lx, 12 + i * 18, 12, 12, box);
                canvas.DrawText(leyendas[i].Item1, lx + 18, 22 + i * 18, legendFont);
            }

            int filas = tabla.Rows.Count;
            if (filas == 0)
            {
                canvas.DrawText("Sin datos para mostrar.", Ancho / 2 - 80, Alto / 2, etiquetaFont);
                return Encode(surface);
            }

            int maxValor = tabla.AsEnumerable()
                .SelectMany(r => new[] { Convert.ToInt32(r["Aprobados"]), Convert.ToInt32(r["Regulares"]), Convert.ToInt32(r["SinNota"]) })
                .Max();
            if (maxValor <= 0) maxValor = 1;

            const int margenIzq = 60;
            const int margenDer = 20;
            const int margenSup = 50;
            const int margenInf = 70;
            int areaAncho = Ancho - margenIzq - margenDer;
            int areaAlto = Alto - margenSup - margenInf;

            for (int i = 0; i <= 5; i++)
            {
                float y = margenSup + areaAlto - (areaAlto * i / 5f);
                float val = maxValor * i / 5f;
                canvas.DrawLine(margenIzq, y, Ancho - margenDer, y, ejePaint);
                canvas.DrawText(((int)val).ToString(), 10, y + 4, valorFont);
            }

            float grupoAncho = areaAncho / filas;
            float barraAncho = grupoAncho * 0.22f;
            float espacio = grupoAncho * 0.10f;

            for (int i = 0; i < filas; i++)
            {
                var row = tabla.Rows[i];
                int aprobados = Convert.ToInt32(row["Aprobados"]);
                int regulares = Convert.ToInt32(row["Regulares"]);
                int sinNota = Convert.ToInt32(row["SinNota"]);

                float grupoX = margenIzq + i * grupoAncho + espacio;

                var valores = new[] { (aprobados, ColorAprobados), (regulares, ColorRegulares), (sinNota, ColorSinNota) };
                for (int j = 0; j < valores.Length; j++)
                {
                    float v = valores[j].Item1;
                    float h = areaAlto * v / maxValor;
                    float x = grupoX + j * (barraAncho + 2);
                    float y = margenSup + areaAlto - h;
                    using var p = new SKPaint { Color = valores[j].Item2, IsAntialias = true };
                    canvas.DrawRect(x, y, barraAncho, h, p);
                    if (v > 0)
                        canvas.DrawText(v.ToString(), x + barraAncho / 2 - 6, y - 3, valorFont);
                }

                string etiqueta = $"{row["Materia"]} ({row["Anio"]})";
                if (etiqueta.Length > 28) etiqueta = etiqueta.Substring(0, 25) + "...";
                float etiquetaX = grupoX + grupoAncho / 2 - espacio;
                var textoRect = new SKRect();
                etiquetaFont.MeasureText(etiqueta, ref textoRect);
                canvas.Save();
                canvas.Translate(etiquetaX - textoRect.Width / 2, Alto - margenInf + 8);
                canvas.RotateDegrees(45);
                canvas.DrawText(etiqueta, 0, 0, etiquetaFont);
                canvas.Restore();
            }

            return Encode(surface);
        }

        public static byte[] TortaCondiciones(DataTable tabla)
        {
            using var surface = SKSurface.Create(new SKImageInfo(Ancho, Alto));
            var canvas = surface.Canvas;
            canvas.Clear(SKColors.White);

            using var tituloFont = new SKPaint
            {
                Color = SKColors.DarkSlateGray,
                IsAntialias = true,
                Typeface = SKTypeface.FromFamilyName("Segoe UI", SKFontStyleWeight.Bold, SKFontStyleWidth.Normal, SKFontStyleSlant.Upright),
                TextSize = 18
            };
            using var legendFont = new SKPaint
            {
                Color = SKColors.DarkSlateGray,
                IsAntialias = true,
                Typeface = SKTypeface.FromFamilyName("Segoe UI", SKFontStyleWeight.Normal, SKFontStyleWidth.Normal, SKFontStyleSlant.Upright),
                TextSize = 12
            };

            int aprobados = 0, regulares = 0, inscriptos = 0;
            foreach (DataRow r in tabla.Rows)
            {
                int condicion = r["Condicion"] == DBNull.Value ? 0 : Convert.ToInt32(r["Condicion"]);
                if (condicion == 2) aprobados++;
                else if (condicion == 1) regulares++;
                else inscriptos++;
            }
            int total = aprobados + regulares + inscriptos;

            canvas.DrawText("Distribución de condiciones", 16, 26, tituloFont);

            if (total == 0)
            {
                using var avisoFont = new SKPaint
                {
                    Color = SKColors.DarkSlateGray,
                    IsAntialias = true,
                    Typeface = SKTypeface.FromFamilyName("Segoe UI", SKFontStyleWeight.Normal, SKFontStyleWidth.Normal, SKFontStyleSlant.Upright),
                    TextSize = 12
                };
                canvas.DrawText("Sin datos para mostrar.", Ancho / 2 - 80, Alto / 2, avisoFont);
                return Encode(surface);
            }

            var segmentos = new[]
            {
                (aprobados, ColorAprobados, "Aprobados"),
                (regulares, ColorRegulares, "Regulares"),
                (inscriptos, ColorSinNota, "Inscriptos (sin nota)")
            };

            float cx = 220, cy = Alto / 2 + 10, radio = 130;
            float startAngle = -90f;
            using var stroke = new SKPaint { Color = SKColors.White, IsStroke = true, StrokeWidth = 2, IsAntialias = true };

            foreach (var seg in segmentos)
            {
                if (seg.Item1 == 0) continue;
                float sweep = 360f * seg.Item1 / total;
                using var paint = new SKPaint { Color = seg.Item2, IsAntialias = true, Style = SKPaintStyle.Fill };
                using var path = new SKPath();
                path.AddArc(new SKRect(cx - radio, cy - radio, cx + radio, cy + radio), startAngle, sweep);
                path.LineTo(cx, cy);
                path.Close();
                canvas.DrawPath(path, paint);
                canvas.DrawPath(path, stroke);
                startAngle += sweep;
            }

            int ly = 80;
            foreach (var seg in segmentos)
            {
                using var box = new SKPaint { Color = seg.Item2, IsAntialias = true };
                canvas.DrawRect(440, ly, 14, 14, box);
                int pct = total == 0 ? 0 : seg.Item1 * 100 / total;
                canvas.DrawText($"{seg.Item3}: {seg.Item1} ({pct}%)", 462, ly + 12, legendFont);
                ly += 28;
            }

            return Encode(surface);
        }

        private static byte[] Encode(SKSurface surface)
        {
            using var image = surface.Snapshot();
            using var data = image.Encode(SKEncodedImageFormat.Png, 100);
            return data.ToArray();
        }
    }
}

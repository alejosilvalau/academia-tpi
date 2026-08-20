using SkiaSharp;
using System.Data;

namespace Repositorio
{
    public static class GraficoGenerador
    {
        private static readonly SKColor ColorAprobados = new(0x4C, 0xAF, 0x50);
        private static readonly SKColor ColorRegulares = new(0xFF, 0xC1, 0x07);
        private static readonly SKColor ColorSinNota = new(0xEF, 0x5C, 0x52);

        public static byte[] BarrasRendimientoDocente(DataTable tabla, int ancho = 500, int alto = 350)
        {
            using var surface = SKSurface.Create(new SKImageInfo(ancho * 2, alto * 2));
            var canvas = surface.Canvas;
            canvas.Scale(2);
            canvas.Clear(SKColors.White);

            using var tituloFont = new SKPaint
            {
                Color = SKColors.DarkSlateGray,
                IsAntialias = true,
                Typeface = SKTypeface.FromFamilyName("Segoe UI", SKFontStyleWeight.Bold, SKFontStyleWidth.Normal, SKFontStyleSlant.Upright),
                TextSize = 13
            };
            using var etiquetaFont = new SKPaint
            {
                Color = SKColors.DarkSlateGray,
                IsAntialias = true,
                Typeface = SKTypeface.FromFamilyName("Segoe UI", SKFontStyleWeight.Normal, SKFontStyleWidth.Normal, SKFontStyleSlant.Upright),
                TextSize = 8
            };
            using var valorFont = new SKPaint
            {
                Color = SKColors.Black,
                IsAntialias = true,
                Typeface = SKTypeface.FromFamilyName("Segoe UI", SKFontStyleWeight.Normal, SKFontStyleWidth.Normal, SKFontStyleSlant.Upright),
                TextSize = 9
            };
            using var ejePaint = new SKPaint { Color = new SKColor(0xCC, 0xCC, 0xCC), StrokeWidth = 1, IsAntialias = true };
            using var legendFont = new SKPaint
            {
                Color = SKColors.DarkSlateGray,
                IsAntialias = true,
                Typeface = SKTypeface.FromFamilyName("Segoe UI", SKFontStyleWeight.Normal, SKFontStyleWidth.Normal, SKFontStyleSlant.Upright),
                TextSize = 9
            };

            var leyendas = new[] { ("Aprobados", ColorAprobados), ("Regulares", ColorRegulares), ("Sin nota", ColorSinNota) };
            float legendTotalWidth = 0;
            foreach (var l in leyendas)
            {
                var rr = new SKRect();
                legendFont.MeasureText(l.Item1, ref rr);
                legendTotalWidth += 12 + 4 + rr.Width + 14;
            }
            float legendStartX = (ancho - legendTotalWidth) / 2;
            float lx = legendStartX;
            foreach (var l in leyendas)
            {
                using var box = new SKPaint { Color = l.Item2, IsAntialias = true };
                canvas.DrawRect(lx, 6, 10, 10, box);
                canvas.DrawText(l.Item1, lx + 14, 15, legendFont);
                var rr = new SKRect();
                legendFont.MeasureText(l.Item1, ref rr);
                lx += 12 + 4 + rr.Width + 14;
            }

            canvas.DrawText("Condiciones por curso", 10, 30, tituloFont);

            int filas = tabla.Rows.Count;
            if (filas == 0)
            {
                canvas.DrawText("Sin datos para mostrar.", ancho / 2 - 60, alto / 2, etiquetaFont);
                return Encode(surface);
            }

            int maxValor = tabla.AsEnumerable()
                .SelectMany(r => new[] { Convert.ToInt32(r["Aprobados"]), Convert.ToInt32(r["Regulares"]), Convert.ToInt32(r["SinNota"]) })
                .Max();
            if (maxValor <= 0) maxValor = 1;

            int margenIzq = 40;
            int margenDer = 10;
            int margenSup = 50;
            int margenInf = 70;
            int areaAncho = ancho - margenIzq - margenDer;
            int areaAlto = alto - margenSup - margenInf;

            for (int i = 0; i <= 5; i++)
            {
                float y = margenSup + areaAlto - (areaAlto * i / 5f);
                float val = maxValor * i / 5f;
                canvas.DrawLine(margenIzq, y, ancho - margenDer, y, ejePaint);
                canvas.DrawText(((int)val).ToString(), 8, y + 3, valorFont);
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
                        canvas.DrawText(v.ToString(), x + barraAncho / 2 - 4, y - 2, valorFont);
                }

                string etiqueta = $"{row["Materia"]} ({row["Anio"]})";
                if (etiqueta.Length > 22) etiqueta = etiqueta.Substring(0, 19) + "...";
                float etiquetaX = grupoX + grupoAncho / 2 - espacio;
                var textoRect = new SKRect();
                etiquetaFont.MeasureText(etiqueta, ref textoRect);
                canvas.Save();
                canvas.Translate(etiquetaX - textoRect.Width / 2, alto - margenInf + 8);
                canvas.RotateDegrees(45);
                canvas.DrawText(etiqueta, 0, 0, etiquetaFont);
                canvas.Restore();
            }

            return Encode(surface);
        }

        public static byte[] TortaCondiciones(DataTable tabla, int ancho = 500, int alto = 350)
        {
            using var surface = SKSurface.Create(new SKImageInfo(ancho * 2, alto * 2));
            var canvas = surface.Canvas;
            canvas.Scale(2);
            canvas.Clear(SKColors.White);

            using var tituloFont = new SKPaint
            {
                Color = SKColors.DarkSlateGray,
                IsAntialias = true,
                Typeface = SKTypeface.FromFamilyName("Segoe UI", SKFontStyleWeight.Bold, SKFontStyleWidth.Normal, SKFontStyleSlant.Upright),
                TextSize = 13
            };
            using var legendFont = new SKPaint
            {
                Color = SKColors.DarkSlateGray,
                IsAntialias = true,
                Typeface = SKTypeface.FromFamilyName("Segoe UI", SKFontStyleWeight.Normal, SKFontStyleWidth.Normal, SKFontStyleSlant.Upright),
                TextSize = 9
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

            canvas.DrawText("Distribución de condiciones", 10, 18, tituloFont);

            if (total == 0)
            {
                using var avisoFont = new SKPaint
                {
                    Color = SKColors.DarkSlateGray,
                    IsAntialias = true,
                    Typeface = SKTypeface.FromFamilyName("Segoe UI", SKFontStyleWeight.Normal, SKFontStyleWidth.Normal, SKFontStyleSlant.Upright),
                    TextSize = 10
                };
                canvas.DrawText("Sin datos para mostrar.", ancho / 2 - 60, alto / 2, avisoFont);
                return Encode(surface);
            }

            var segmentos = new[]
            {
                (aprobados, ColorAprobados, "Aprobados"),
                (regulares, ColorRegulares, "Regulares"),
                (inscriptos, ColorSinNota, "Inscriptos (sin nota)")
            };

            float radio = alto * 0.35f;
            float cx = ancho * 0.30f;
            float cy = alto * 0.55f;
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

            int legendX = (int)(cx + radio + 20);
            int ly = (int)(cy - 30);
            foreach (var seg in segmentos)
            {
                using var box = new SKPaint { Color = seg.Item2, IsAntialias = true };
                canvas.DrawRect(legendX, ly, 10, 10, box);
                int pct = total == 0 ? 0 : seg.Item1 * 100 / total;
                canvas.DrawText($"{seg.Item3}: {seg.Item1} ({pct}%)", legendX + 16, ly + 9, legendFont);
                ly += 20;
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

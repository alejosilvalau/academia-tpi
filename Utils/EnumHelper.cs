using System.ComponentModel;
using System.Reflection;

namespace Utils
{
    public static class EnumHelper
    {
        public static List<object> GetEnumItems<T>() where T : struct, Enum
        {
            var items = new List<object>();
            foreach (T value in Enum.GetValues(typeof(T)))
            {
                var field = typeof(T).GetField(value.ToString());
                var attr = field?.GetCustomAttribute<DescriptionAttribute>();
                items.Add(new { Display = attr?.Description ?? value.ToString(), Value = value });
            }
            return items;
        }
    }
}

using System.ComponentModel;
using System.Reflection;

namespace BeastTribes
{
    public static class Extensions
    {
        public static void InitializePropertyDefaultValues(this object obj)
        {
            PropertyInfo[] props = obj.GetType().GetProperties();
            foreach (PropertyInfo prop in props)
            {
                var d = prop.GetCustomAttribute<DefaultValueAttribute>();
                if (d != null)
                    prop.SetValue(obj, d.Value);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Chromedia.DataAccess.JsonModels;

namespace Chromedia.DataAccess.Utilities
{
    public static class GenericExtensions
    {
        public static object? GetMyProperty<T>(this T jObject, string propertyName)
        {
            PropertyInfo prop = typeof(T).GetProperty(propertyName);
            var data = prop.GetValue(jObject);

            return data;
        }
    }
}

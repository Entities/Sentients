using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Toolkit.UnitTests
{
    public class JsonHelper
    {
        /// <summary>
        /// Returns the Property Name of a JSON Entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerationName"></param>
        /// <returns></returns>
        public static string GetJsonPropertyNameAttribute<T>(string enumerationName)
        {
            var member = typeof(T).GetMember(enumerationName);
            return member.Count() > 0
                ? ((JsonPropertyAttribute)(member[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false))[0]).PropertyName
                : null;
        }
    }
}

using System.ComponentModel;
using System.Linq;

namespace Toolkit.UnitTests
{
    public class EnumHelper
    {
        /// <summary>
        /// Returns the Description attribute of an Enumeration type
        /// </summary>
        /// <typeparam name="Enum"></typeparam>
        /// <param name="enumerationName"></param>
        /// <returns></returns>
        public static string GetDescriptionFromEnumName<Enum>(string enumerationName)
        {
            var member = typeof(Enum).GetMember(enumerationName);
            return member.Count() > 0
                ? ((DescriptionAttribute)(member[0].GetCustomAttributes(typeof(DescriptionAttribute), false))[0]).Description
                : null;
        }
    }
}

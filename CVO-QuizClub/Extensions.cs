using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CVO_QuizClub
{
    public static class Extensions
    {
        // Extension method.
        // Geeft de inhoud van de 'Description' decorator terug voor een enum-element.
        // Als er geen Description gedefinieerd is, wordt de string-waarde van het enum-element gegeven.
        public static string GetDescription(this Enum genericEnum)
        {
            Type genericEnumType = genericEnum.GetType();
            MemberInfo[] memberInfo = genericEnumType.GetMember(genericEnum.ToString());
            if(memberInfo != null && memberInfo.Length > 0)
            {
                var attributes = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if(attributes != null && attributes.Count() > 0)
                {
                    return ((DescriptionAttribute)attributes.ElementAt(0)).Description;
                }
            }
            return genericEnum.ToString();
        }
    }
}

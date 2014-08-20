using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeLibrary.Helpers
{
    public class AttributeHelpers
    {
        public static IEnumerable<Type> GetAttributeTypesFrom(Type type)
        {
            var targetmethod = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public).SingleOrDefault(method => method.Name == "OnHandle");

            return targetmethod.GetCustomAttributes(true)
                .Select(attr => (Attribute)attr)
                .Where(a => a.GetType().BaseType == typeof(MessageHandlerDecoratorAttribute))
                .Select(a => a.GetType())
                .ToList();
        }
    }
}

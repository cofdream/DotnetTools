using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cofdream.Tools
{
    public static class ReflectionUtility
    {
        public static string GetFieldNameOfAutoProperty(string autoPropertyName)
        {
            return $"<{autoPropertyName}>k__BackingField";
        }
    }
}

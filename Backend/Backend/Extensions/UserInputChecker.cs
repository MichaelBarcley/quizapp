using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Extensions
{
    public static class UserInputChecker
    {
        public static bool IsAnyPropertyNull(this QuizQuestion o)
        {
            var properties = o.GetType().GetProperties();
            foreach (var property in properties)
            {
                if (property.GetValue(o) == null)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsAnyStringPropertyEmpty(this QuizQuestion o)
        {
            var properties = o.GetType().GetProperties();
            foreach (var property in properties)
            {
                if (property.PropertyType.Name == "String" && (string)property.GetValue(o) == string.Empty)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

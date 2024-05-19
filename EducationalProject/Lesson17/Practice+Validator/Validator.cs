using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Lesson17.Practice
{
    public static class Validator
    {
        public static bool Validate(object obj)
        {
            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                object[] attributes = property.GetCustomAttributes(typeof(ValidationAttribute), true);

                foreach (ValidationAttribute attribute in attributes)
                {
                    object? value = property.GetValue(obj);

                    if (value is not null && !attribute.IsValid(value))
                    {
                        Console.WriteLine($"Validation failed for {property.Name}: {attribute.ErrorMessage}");
                        Console.WriteLine();
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool HasAttributes(Contact obj)
        {
            var attributes = obj.GetType().GetCustomAttributes(false);

            return attributes.Any(a => a.GetType() == typeof(CustomForClassAttribute));
        }
    }
}

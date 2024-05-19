namespace Lesson17.Practice
{
        public static class ValidatorService
        {
            public static void ShowValidation()
            {
                Contact validContact = new Contact
                {
                    Name = "John",
                    Email = "john@example.com",
                    Phone = "+123456789"
                };

                Contact invalidEmailContact = new Contact
                {
                    Name = "John",
                    Email = "",
                    Phone = "+15551234"

                };

                Contact invalidNameContact = new Contact
                {
                    Name = "J",
                    Email = "john@example.com",
                    Phone = "+1987654321"
                };

                Contact emptyNameContact = new Contact
                {
                    Name = "",
                    Email = "john@example.com",
                    Phone = "+19876765321"
                };

                Contact invalidPhoneContact = new Contact
                {
                    Name = "John",
                    Email = "john@example.com",
                    Phone = ""
                };

                Validator.Validate(validContact);
                Validator.Validate(invalidEmailContact);
                Validator.Validate(emptyNameContact);
                Validator.Validate(invalidNameContact);
                Validator.Validate(invalidPhoneContact);
            }
        }
    }

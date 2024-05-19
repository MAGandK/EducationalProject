namespace Lesson17
{
	public class ContactService
	{
		private List<Contact> contacts = new List<Contact>
		{
            new Contact { Name = "John Doe", Email = "john@example.com", Phone = "+123456789" },
			new Contact { Name = "Jane Smith", Email = "", Phone = "+15551234" },
			new Contact { Name = "Bob Johnson", Email = "bob@example.com", Phone = "+1987654321" },
			new Contact { Name = "Alice Brown", Email = "alice@example.com", Phone = "" }

        };

		public void GetContactEmptyEmail()
		{
			var result = contacts.Where(c => string.IsNullOrEmpty(c.Email)).First();

			Console.WriteLine("Контакт с пустым email: ");

			Display(result);
		}

		public void GetContactWithPhoneFilter()
		{
			var result = contacts.Where(c => c.Phone.StartsWith("+1")).Last();

			Console.WriteLine("Контакт с кодом страны '+1'");

			Display(result);
		}

		public void GetContactWithLongName()
		{
			var result = contacts.Where(c => c.Name.Length > 10).FirstOrDefault();
            Console.WriteLine("Контакт с именем больше 10-ти символов: ");

			Display(result);
        }

		public void GetContactWithFullInfo()
		{
			var result = contacts.Where(c => !string.IsNullOrEmpty(c.Email)
											&& !string.IsNullOrEmpty(c.Name)
											&& !string.IsNullOrEmpty(c.Phone)).LastOrDefault();

			Console.WriteLine("Полностью заполненый контакт: ");

			Display(result);
		}


		private void Display(Contact contact)
		{
			var properties = contact.GetType().GetProperties();

			foreach (var prop in properties)
			{
				Console.WriteLine($"{prop.Name} - {prop.GetValue(contact)}");
			}
		}
	}
}


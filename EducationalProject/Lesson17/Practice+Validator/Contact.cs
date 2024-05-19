using System.ComponentModel.DataAnnotations;

namespace Lesson17
{
	public class Contact
	{
		[Required(ErrorMessage = "Name is required.")]
		public string Name { get; set; }

		[EmailAddress(ErrorMessage = "Email is not valid.")]
        public string Email { get; set; }

		[Phone(ErrorMessage ="Phone is not valid")]
        public string Phone { get; set; }

        public Contact( string name, string email, string phone)
		{
			Name = name;
			Email = email;
			Phone = phone;
		}

		public Contact()
		{

		}
	}
}

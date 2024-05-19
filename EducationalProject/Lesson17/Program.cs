using System.ComponentModel.DataAnnotations;
using Lesson17.Practice;

namespace Lesson17;

class Program
{
    static void Main(string[] args)
    {
        ContactService service = new();

        //service.GetContactEmptyEmail();
        //service.GetContactWithFullInfo();
        //service.GetContactWithLongName();
        //service.GetContactWithPhoneFilter();



        ValidatorService.ShowValidation();
    }
}


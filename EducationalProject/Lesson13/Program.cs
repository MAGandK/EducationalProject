namespace Lesson13;

class Program
{
    static void Main(string[] args)
    {
        var mugManager = new ItemManager<Mug>();

        var phoneManager = new ItemManager<Phone>();

        var mug1 = new Mug("Steel", 10);
        var mug2 = new Mug("Plastic", 2);

        var phone1 = new Phone("Siemens", 100);
        var phone2 = new Phone("Samsung", 330);

        List<Mug> items = new List<Mug>{mug1, mug2};
        mugManager.Add(items);

        phoneManager.Add(phone1);
        phoneManager.Add(phone2);

        List<Phone> items1 = new List<Phone> { phone1, phone2 };


        try
        {
            //var mug4 = new Mug("Steel", 0);
            var phone3 = new Phone("ZE", 120);
        }
        catch(MugExсeption ex)
        {
            Console.WriteLine("Error in Mug: " + ex.Message);
            Console.WriteLine("Incorrect value: " + ex.Value);
        }
        catch(PhoneExсeption ex)
        {
            Console.WriteLine("Error in Phone: " + ex.Message);
            Console.WriteLine("Incorrect value: " + ex.Value);
        }
    }
}
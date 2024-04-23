using System.Collections.Generic;

namespace Lesson10
{
    public interface IPersonManagement<T> where T : Person
    {
        List<T> GetAll();

        void DisplayPerson(T person);
    }
}
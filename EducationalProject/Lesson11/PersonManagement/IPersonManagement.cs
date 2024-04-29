using System.Collections.Generic;

namespace Lesson11
{
    public interface IPersonManagement<T> 
    {
        void Add(T person);
        List<T> DisplayAll();
        void Display(T person);
    }
}
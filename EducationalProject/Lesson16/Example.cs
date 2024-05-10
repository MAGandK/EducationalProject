using System;
namespace Lesson16;
//{
//    Natalia Вырва С#, [07/05/2024 19:30]
//public class LINQCheatSheet
//    {
//        // Исходные данные - список пользователей
//        List<User> users =
    
//            [
//                new User(1, "Alice", 25),
//                new User(2, "Bob", 30),
//                new User(3, "Charlie", 20),
//                new User(4, "David", 35),
//                new User(5, "Eve", 28),
    
//            ];

//        List<Order> orders =
    
//            [
//                new Order(1, 1, 100),
//                new Order(2, 3, 200),
//                new Order(3, 2, 150),
//                new Order(4, 1, 300),
//                new Order(5, 4, 250),
    
//            ];

//        public void Demo()
//        {
//            // Примеры основных конструкций и методов расширения LINQ

//            // 1. Фильтрация данных
//            var filteredByAge = users.Where(user => user.Age >= 25);
//            var filteredByAgeLinq = from user in users
//                                    where user.Age >= 25
//                                    select user;

//            var filteredByAgeAndName = users.Where(user => user.Age >= 25 && user.Name.StartsWith('A'));
//            var filteredByAgeAndNameLinq = from user in users
//                                           where user.Age >= 25 && user.Name.StartsWith('A')
//                                           select user;

//            // 2. Сортировка данных
//            var orderedByAge = users.OrderBy(user => user.Age);
//            var orderedByAgeLinq = from user in users
//                                   orderby user.Age
//                                   select user;

//            // 3. Группировка данных
//            var groupedByAge = users.GroupBy(user => user.Age);
//            var groupedByAgeLinq = from user in users
//                                   group user by user.Age;

//            // 4. Выборка данных
//            var selectedByName = users.Select(user => user.Name);
//            var selectedByNameLinq = from user in users
//                                     select user.Name;

//            // 5. Преобразование данных
//            var modifiedList = users.Select(user => new { user.Name, user.Age });
//            var modifiedListLinq = from user in users
//                                   select new { user.Name, user.Age };

//            foreach (var item in modifiedList)
//            {
//                Console.WriteLine($"Name: {item.Name}, Age: {item.Age}");
//            }

//            // 6. Удаление дубликатов
//            var distinctUsers = users.Select(user => user.Age).Distinct();
//            var distinctUsersLinq = (from user in users
//                                     select user.Age).Distinct();

//            // 7. Исключение элементов из одной последовательности на основе другой
//            var excludeUsers = new List<User> { users[0], users[2] };

//            var usersExceptTwoEntries = users.Except(excludeUsers);
//            var usersExceptTwoEntriesLinq = from user in users
//                                            where !excludeUsers.Contains(user)
//                                            select user;

//            // 8. Использование оператора let для временной переменной
//            var tempField = from user in users
//                            let fullName = $"{user.Name} ({user.Age} years old)"
//                            select new
//                            {
//                                Id = user.Id,
//                                FullName = fullName
//                            };

//            // 9. Использования запроса из нескольких источников
//            var newDataSet = users.Join(
//                                    orders,
//                                    u => u.Id,
//                                    o => o.UserId,
//                                    (u, o) => new { Name = u.Name, OrderId = o.OrderId, o.Amount });
//            var newDataSetLinq = from user in users
//                                 join order in orders on user.Id equals order.UserId
//                                 select new
//                                 {
//                                     user.Name,
//                                     user.Age,
//                                     order.Amount
//                                 };
//        }
//    }

//    internal class User(int id, string name, int age)
//    {
//        public int Id { get; set; } = id;
//        public string Name { get; set; } = name;
//        public int Age { get; set; } = age;
//    }

//    Natalia Вырва С#, [07/05/2024 19:30]


//internal class Order(int orderId, int userId, decimal amount)
//    {
//        public int OrderId { get; set; } = orderId;
//        public int UserId { get; set; } = userId;
//        public decimal Amount { get; set; } = amount;
//    }

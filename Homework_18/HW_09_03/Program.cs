using HW_09_03.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace HW_09_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Account[] accounts = new Account[20];
            Hotel[] hotels = new Hotel[50];
            List<int> numbersInHotelBase = new();
            List<int> numbersInRoomBase = new();
            string answer;

            void CreateBaseOfAcconts()
            {
                accounts[0] = new Account("User1", "123");
                accounts[1] = new Account("User2", "1234");
                accounts[2] = new Account("User3", "12345");
                accounts[3] = new Account("User4", "123456");
                accounts[4] = new Account("User5", "1234567");
            }
            void CreateBaseOfHotel()
            {
                hotels[0] = new Hotel("Вроцлав", "B & B Hotel Wrocław Centrum", "Отель типа «постель и завтрак» Wrocław Centrum удобно расположен в центре города. Гостям предлагается размещение в современных номерах с бесплатным Wi-Fi.");
                hotels[1] = new Hotel("Вроцлав", "ONE LUCKY HOSTEL", "Хостел One Lucky - Old Town находится во Вроцлаве, менее чем в 300 м от Главной рыночной площади, в 400 м от городской ратуши и в 600 м от Соляной площади.");
                hotels[2] = new Hotel("Вроцлав", "Apartamenty Sky Tower z Wanna Przy Oknie", "Апартаменты. Кухня. Вид на город. Бесплатный Wi - Fi. Ванна. Апартаменты Apartamenty Sky Tower z Wanna Przy Oknie с панорамным видом на город расположены в самом высоком здании Вроцлава в Польше.К услугам гостей апартаменты с собственной кухней.Предоставляется бесплатный Wi - Fi.");
                hotels[3] = new Hotel("Вильнюс", "Radisson Blu Hotel Lietuva", "Элегантный 4-звездочный отель Radisson Blu Lietuva расположен на берегу реки Нерис в центре Вильнюса. К услугам гостей парковка на территории, просторные номера с бесплатным Wi-Fi и фитнес-центр.");
                hotels[4] = new Hotel("Вильнюс", "Ratonda Centrum Hotels", "Четырехзвездочный отель Ratonda Centrum расположен на главной улице Вильнюса, в 15 минутах ходьбы от Старого города. К услугам гостей этого семейного бутик-отеля номера с бесплатным Wi-Fi, кондиционером и мини-баром (за дополнительную плату).");
                hotels[5] = new Hotel("Прага", "Occidental Praha Wilson", "Отель Occidental Praha Wilson с мини-маркетом, баром и бесплатным Wi-Fi на всей территории расположен в Праге на Вацлавской площади, рядом с Пражским национальным музеем и Государственной оперой. По утрам в ресторане сервируется завтрак «шведский стол».");
                hotels[6] = new Hotel("Прага", "OREA Hotel Pyramida Praha", "Отель Orea Pyramida расположен в 10 минутах ходьбы от Пражского Града и в 15 минутах езды на общественном транспорте от центра города.Гости могут бесплатно посещать крытый бассейн и фитнес - центр.");
                hotels[7] = new Hotel("Барселона", "Hotel Best Front Maritim", "Отель Front Maritim находится в 100 метрах от пляжа Нова-Мар-Белла в Барселоне. К услугам гостей бесплатный Wi-Fi и тренажерный зал с сауной. За 15 минут можно дойти до парка Форум и Международного конференц-центра Барселоны.");
            }
            void CreateOfRooms()
            {
                hotels[0].CreateRoom(new Room(2, "Двухместный номер с 1ой кроватью", 100, 10));
                hotels[0].CreateRoom(new Room(2, "Двухместный номер с двумя отдельными кроватями", 110, 15));
                hotels[0].CreateRoom(new Room(1, "Одноместный номер", 90, 12));

                hotels[1].CreateRoom(new Room(2, "Двухместный номер с 1ой кроватью", 50, 10));
                hotels[1].CreateRoom(new Room(2, "Двухместный номер с двумя отдельными кроватями", 55, 15));
                hotels[1].CreateRoom(new Room(1, "Одноместный номер", 45, 12));

                hotels[2].CreateRoom(new Room(2, "Двухместный номер с 1ой кроватью", 250, 1));

                hotels[3].CreateRoom(new Room(2, "Двухместный номер с 1ой кроватью", 100, 10));
                hotels[3].CreateRoom(new Room(2, "Двухместный номер с двумя отдельными кроватями", 110, 15));
                hotels[3].CreateRoom(new Room(1, "Одноместный номер", 90, 12));

                hotels[4].CreateRoom(new Room(2, "Двухместный номер с двумя отдельными кроватями", 110, 15));
                hotels[4].CreateRoom(new Room(1, "Одноместный номер", 90, 12));

                hotels[5].CreateRoom(new Room(2, "Двухместный номер с 1ой кроватью", 100, 10));
                hotels[5].CreateRoom(new Room(2, "Двухместный номер с двумя отдельными кроватями", 110, 15));

                hotels[6].CreateRoom(new Room(1, "Одноместный номер", 90, 12));

                hotels[7].CreateRoom(new Room(2, "Двухместный номер с 1ой кроватью", 150, 5));
                hotels[7].CreateRoom(new Room(2, "Двухместный номер с двумя отдельными кроватями", 155, 4));
                hotels[7].CreateRoom(new Room(1, "Одноместный номер", 145, 3));
            }
            void SearchUser(string login, string pass)
            {
                int index = SearchFirstNullElement(accounts);

                var result = accounts.Where(s => s != null && s.Login == login);
                if (!result.Any())
                {
                    Console.WriteLine("Register new user " + login);
                    accounts[index] = new Account(login, pass);
                }
                else
                {
                    if (result.First().Password != pass)
                    {
                        Console.WriteLine("Wrong pass!. Please, try again.");
                        while (true)
                        {
                            pass = Console.ReadLine();
                            if (pass.Equals(result.First().Password))
                            {
                                break;
                            }
                            else
                                Console.WriteLine("Wrong pass!. Please, try again.");
                        }
                        Console.Clear();
                    }
                    Console.WriteLine("Hello, " + result.First().Login + "!");
                }
            }

            void ShowRoom(Hotel hotel)
            {
                int index = SearchFirstNullElement(hotel._rooms);

                for (int i = 0; i < index; i++)
                {
                    if (hotel._rooms[i].CountOfThisRoom != 0)
                    {
                        Console.WriteLine($"{i}. {hotel._rooms[i].Description}.\n Max count of people in the room: {hotel._rooms[i].CountOfPeople}.\n Number of available rooms: {hotel._rooms[i].CountOfThisRoom}");
                        numbersInRoomBase.Add(i);
                    }
                }
            }
            int SearchFirstNullElement(object[] arr)
            {
                int index = arr.Length;

                for (int i = 0; i < index; i++)
                {
                    if (arr[i] is null)
                    {
                        index = i;
                        break;
                    }
                }
                return index;
            }
            int ChooseHotelOrRoom(List<int> numbersInBase)
            {
                bool choice = default;
                string output = string.Empty;

                while (!choice)
                {
                    Console.WriteLine("Please, choose the list number you are interested in.");
                    output = Console.ReadLine();
                    choice = Int32.TryParse(output, out int result);
                    if (!numbersInBase.Contains(result))
                    {
                        choice = false;
                        Console.WriteLine("Wrong choice!");
                    }
                }
                return Convert.ToInt32(output);
            }
            int InputCountOfNumbers(int available)
            {
                bool flag = default;
                string output;

                while (!flag)
                {
                    output = Console.ReadLine();
                    flag = Int32.TryParse(output, out int result);
                    if (!flag)
                        Console.WriteLine("It's not a number! Please, try again!");
                    else if (result > available)
                    {
                        Console.WriteLine("Exceeded the max available quantity of rooms. Please, try again.");
                        flag = false;
                    }
                    else
                        return result;
                }
                return 0;
            }
            bool CreateOrLogin()
            {
                bool flag;

                while (true)
                {
                    answer = Console.ReadLine().ToLower();
                    if (answer.Equals("да") || answer.Equals("yes"))
                    {
                        flag = true;
                        break;
                    }
                    else if (answer.Equals("нет") || answer.Equals("no"))
                    {
                        flag = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please, try again.");
                    }
                }
                Console.Clear();
                return flag;
            }
            string SearchHotels(string destinationCity)
            {
                int index = SearchFirstNullElement(hotels);
                int count = 0;

                while (count == 0)
                {
                    for (int i = 0; i < index; i++)
                    {
                        if (destinationCity.Equals(hotels[i].City))
                        {
                            Console.WriteLine($"{i}. Hotel: {hotels[i].Name}.\n Description: {hotels[i].Description}");
                            count++;
                            numbersInHotelBase.Add(i);
                        }
                    }
                    if (count == 0)
                    {
                        Console.WriteLine("No results. Please, change the destination city.");
                        destinationCity = Console.ReadLine();
                    }
                }
                return destinationCity;
            }
            DateTime InputDate(string type)
            {
                DateTime date;
                string input;

                do
                {
                    Console.WriteLine($"Please, input {type} date in dd.mm.yyyy (day, month, year) format: ");
                    input = Console.ReadLine();
                }
                while (!DateTime.TryParseExact(input, "dd.MM.yyyy", null, DateTimeStyles.None, out date) || (date - DateTime.Today).TotalDays < 0);
                return date;
            }

            CreateBaseOfAcconts();
            CreateBaseOfHotel();
            CreateOfRooms();

            Console.WriteLine("Would you like to log or register?");
            Console.WriteLine("Please, input 'yes' or 'да' if yes. 'no' or 'нет' if no.");

            if (CreateOrLogin())
            {
                Console.WriteLine("Please, input login.");
                string login = Console.ReadLine();
                Console.WriteLine("Please, input password.");
                string password = Console.ReadLine(); // Вадим, есть ли именно в консоли маскировка ввода текста на конкретной строке? Или замена на звездочки?
                SearchUser(login, password);
            }

            Console.WriteLine("Please input destination city.");
            string destinationCity = Console.ReadLine();
            destinationCity = SearchHotels(destinationCity);

            int choiceOfHotel = ChooseHotelOrRoom(numbersInHotelBase);
            Console.Clear();
            Console.WriteLine($"Your choice is {hotels[choiceOfHotel].Name} in {destinationCity}.");

            Console.WriteLine("Available rooms:");
            ShowRoom(hotels[choiceOfHotel]);

            int choiceOfRoom = ChooseHotelOrRoom(numbersInRoomBase);
            Console.Clear();

            Console.WriteLine("Please, specify the reqired number of rooms. Available quantity -- " + hotels[choiceOfHotel]._rooms[choiceOfRoom].CountOfThisRoom);
            int countOfRooms = InputCountOfNumbers(hotels[choiceOfHotel]._rooms[choiceOfRoom].CountOfThisRoom);

            DateTime checkInDate = InputDate("check-in");
            DateTime checkOutDate = InputDate("check-out");
            while ((checkOutDate - checkInDate).TotalDays < 1)
            {
                Console.WriteLine("The check-out date must be greater than the check-in date.");
                checkOutDate = InputDate("check-out");
            }
            checkInDate = checkInDate.Date.AddHours(14);
            checkOutDate = checkOutDate.Date.AddHours(12);

            Console.WriteLine($"Your choice is {countOfRooms} {hotels[choiceOfHotel]._rooms[choiceOfRoom].Description} in {hotels[choiceOfHotel].Name} in {destinationCity}.");
            Console.WriteLine($" Check-in date: {checkInDate}. Check-out date: {checkOutDate}.");

            Console.WriteLine("Please, input your data.");
            Console.Write("Your firstName: ");
            string firstName = Console.ReadLine();
            Console.Write("Your lastName: ");
            string lastName = Console.ReadLine();
            Console.Write("Your e-mail: ");
            string email = Console.ReadLine();
            Console.Write("Your address: ");
            string address = Console.ReadLine();
            Console.Write("Your city: ");
            string city = Console.ReadLine();
            Console.Write("Your country: ");
            string country = Console.ReadLine();
            Console.Write("Your phone: ");
            string phone = Console.ReadLine();
            Console.Write("Your wishes: ");
            string wishes = Console.ReadLine();

            hotels[choiceOfHotel].SaveNewGuest(new Guest(hotels[choiceOfHotel]._rooms[choiceOfRoom], lastName, firstName, email, address, city, country, phone, wishes));
            Console.Clear();

            Console.WriteLine($"Congratulations, {lastName} {firstName}"!);
            Console.WriteLine("Your booking is confirmed!");
            Console.WriteLine($"Your choice is {countOfRooms} {hotels[choiceOfHotel]._rooms[choiceOfRoom].Description} in {hotels[choiceOfHotel].Name} in {destinationCity}.");
            Console.WriteLine($"Check-in data: {checkInDate}. Check-out data: {checkOutDate}.");
            Console.WriteLine($"For more information see {email}.");
        }
    }
}
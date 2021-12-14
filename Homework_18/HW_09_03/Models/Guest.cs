namespace HW_09_03.Models
{
    class Guest
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Wishes { get; set; }
        public string Email { get; set; }
        public string YourAddress { get; set; }
        public string YourCity { get; set; }
        public string YourCountry { get; set; }
        public string YourPhone { get; set; }
        public Room TypeOfRoom { get; set; }

        public Guest()
        {
            LastName = string.Empty;
            FirstName = string.Empty;
            Wishes = string.Empty;
            Email = string.Empty;
            YourAddress = string.Empty;
            YourCity = string.Empty;
            YourCountry = string.Empty;
            YourPhone = string.Empty;
        }
        public Guest(Room room, string lastName, string firstName, string email, string adress, string city, string country, string phone, string wishes = "")
        {
            TypeOfRoom = room;
            LastName = lastName;
            FirstName = firstName;
            Wishes = wishes;
            Email = email;
            YourAddress = adress;
            YourCity = city;
            YourCountry = country;
            YourPhone = phone;
        }
    }
}
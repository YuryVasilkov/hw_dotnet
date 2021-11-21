namespace HW_09_03.Booking.Com.Models
{
    class Hotel
    {
        private int _countOfTypeRooms = 0;
        private int _countOfGuests = 0;
        public readonly Room[] _rooms = new Room[10];
        private readonly Guest[] _guests = new Guest[20];

        public string City { get; }
        public string Name { get; }
        public string Description { get; }

        public Hotel()
        {
            City = string.Empty;
            Name = string.Empty;
            Description = string.Empty;
        }
        public Hotel(string city, string name, string description)
        {
            City = city;
            Name = name;
            Description = description;
        }

        public void CreateRoom (Room room)
        {
            _rooms[_countOfTypeRooms] = room;
            _countOfTypeRooms++;
        }
        public void SaveNewGuest(Guest guest)
        {
            _guests[_countOfGuests] = new Guest(guest.TypeOfRoom, guest.LastName, guest.FirstName, guest.Email, guest.YourAddress, guest.YourCity, guest.YourCountry, guest.YourPhone, guest.Wishes);
            guest.TypeOfRoom.CountOfThisRoom--;
            _countOfGuests++;
        }
    }
}
namespace HW_09_03.Booking.Com.Models
{
    class Hotel
    {
        private int _countOfTypeRooms = 0;
        private int _countOfGuests = 0;
        public readonly Room[] _rooms = new Room[10];
        private readonly GuestData[] _guests = new GuestData[20];

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
        public void SaveNewGuest(Room room, string lastName, string firstName, string email, string adress, string city, string country, string phone, string wishes)
        {
            _guests[_countOfGuests] = new GuestData(room, lastName, firstName, email, adress, city, country, phone, wishes);
            room.CountOfThisRoom--;
            _countOfGuests++;
        }
    }
}
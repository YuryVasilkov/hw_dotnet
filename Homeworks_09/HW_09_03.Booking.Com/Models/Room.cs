namespace HW_09_03.Booking.Com.Models
{
    class Room
    {  
        public int CountOfPeople { get; }
        public string Description { get; }
        public int Price { get; }
        public int CountOfThisRoom { get; set; }

        public Room()
        {
            CountOfPeople = 0;
            Description = string.Empty;
            Price = 0;
        }
        public Room(int countOfPeople, string description, int price, int countOfThisRoom)
        {
            CountOfPeople = countOfPeople;
            Description = description;
            Price = price;
            CountOfThisRoom = countOfThisRoom;
        }
    }
}
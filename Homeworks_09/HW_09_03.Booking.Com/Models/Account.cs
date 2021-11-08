namespace HW_09_03.Booking.Com.Models
{
    class Account
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public Account()
        {
            Login = string.Empty;
            Password = string.Empty;
        }
        public Account(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
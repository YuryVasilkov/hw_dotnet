namespace HW_10_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new();
            person.SayHello();

            Student student = new();
            student.SetAge(21);
            student.SayHello();
            student.ShowAge();

            Teacher teacher = new();
            teacher.SetAge(30);
            teacher.SayHello();
            teacher.Explain();
        }
    }
}
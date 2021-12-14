using System;
using Serilog;

namespace HW_13_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.File(@"C:\Temp\Log.log", rollingInterval: RollingInterval.Hour)
                                                  .WriteTo.Console().CreateLogger();

            Log.Warning("Application Homeworks_13.HW_13.02 was created!");

            MotoArray array = new();
            MotoList list = new();
            Exception MotorcycleNotFoundException = new(message: "Motorcycle not found!");
            Log.Information($"{array}, {list}, {MotorcycleNotFoundException} were created.");

            array.UpdateMotorcycleByID(3);
            Log.Information($"{array} was updated!");
            Console.Clear();
            Log.Information("Console was cleared.");
            array.GetAllMotorcycles();

            Console.WriteLine(new string('*', 60));

            list.GetMotorcycleByID(4);
            list.CreateMotorcycle(new Motorcycle(6, "Honda", "ViperSport", 2015, 5000));
            list.GetAllMotorcycles();

            try
            {
                throw MotorcycleNotFoundException;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error!");
            }
            finally
            {
                Log.Warning("Finish work!");
                Log.CloseAndFlush();
            }
        }
    }
}
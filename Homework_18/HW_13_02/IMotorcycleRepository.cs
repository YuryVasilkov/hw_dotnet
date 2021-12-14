namespace HW_13_02
{
    interface IMotorcycleRepository<T>
    {
        void GetMotorcycleByID(int id);
        void GetAllMotorcycles();
        void CreateMotorcycle(T moto);
        void UpdateMotorcycleByID(int id);
        void DeleteMotorcycleByID(int id);
        void DeleteMotorcycleByName(string name);
    }
}
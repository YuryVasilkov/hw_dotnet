namespace HW_14_1
{
    interface IRepository<T>
    {
        T GetByID(int id);
        T[] GetAll();
        void Create(T entity);
        void UpdateByID(int id);
        void DeleteByID(int id);
        void DeleteByName(string name);
    }
}
namespace AnimalsRegistre.Services
{
    public interface IRepository<T,Tid>
    {
        IList<T> GetAll();
        T GetById(Tid id);
        int Create(T item);
        int Update(T item);
        int Delete(T item);
    }
}

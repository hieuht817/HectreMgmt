namespace HectreMgmt.Domain.Interface
{
    public interface IRepo<T>
    {
        List<T> Gets();
        T Get(int id);
    }
}

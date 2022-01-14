namespace HectreMgmt.Domain.Interface
{
    public interface IListPagingRepo<T>
    {
        List<T> Gets(int cursor, int pageSize);
    }
}

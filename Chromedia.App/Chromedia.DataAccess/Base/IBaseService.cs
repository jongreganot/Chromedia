namespace Chromedia.DataAccess.Base
{
    public interface IBaseService<T>
    {
        public Task<List<T>> GetAll();
    }
}

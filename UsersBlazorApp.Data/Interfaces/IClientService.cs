namespace UsersBlazorApp.Data.Interfaces;

public interface IClientService<T>
{
	Task<List<T>> GetAllAsync();
	Task<T> GetByIdAsync(int id);
	Task<T> AddAsync(T entity);
	Task<bool> UpdateAsync(T entity);
	Task<bool> DeleteAsync(int id);
}

namespace UsersBlazorApp.Data.Interfaces;

public interface IApiService<T>
{
	Task<List<T>> GetAllAsync();
	Task<T> GetByIdAsync(int id);
	Task<T> AddAsync(T user);
	Task<bool> UpdateAsync(T user);
	Task<bool> DeleteAsync(int id);
}

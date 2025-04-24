using MotappApi.Models;

namespace MotappApi.Repositories.Interfaces;

public interface IMotoRepository {
    Task<List<Moto>> GetAllAsync();
    Task<Moto?> GetByIdAsync(int id);
    Task AddAsync(Moto moto);
    Task UpdateAsync(Moto moto);
    Task DeleteAsync(Task<Moto?> moto);
}

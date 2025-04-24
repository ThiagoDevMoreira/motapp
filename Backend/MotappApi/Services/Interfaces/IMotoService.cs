using MotappApi.Models;

namespace MotappApi.Services.Interfaces;

public interface IMotoService {
    Task<List<Moto>> GetAllAsync();
    Task<Moto?> GetByIdAsync(int id);
    Task AddAsync(Moto moto);
    Task UpdateAsync(Moto moto);
    Task DeleteAsync(int id);
}

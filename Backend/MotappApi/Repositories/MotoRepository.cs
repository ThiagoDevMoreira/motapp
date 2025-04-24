using Microsoft.EntityFrameworkCore;
using MotappApi.Data;
using MotappApi.Models;
using MotappApi.Repositories.Interfaces;

namespace MotappApi.Repositories;

public class MotoRepository : IMotoRepository {
    private readonly MotappDbContext _context;

    public MotoRepository(MotappDbContext context){
        _context = context;
    }

    public async Task<List<Moto>> GetAllAsync() =>
        await _context.Motos.ToListAsync();
    
    public async Task<Moto?> GetByIdAsync(int id) =>
        await _context.Motos.FindAsync(id);

    public async Task AddAsync(Moto moto) {
        await _context.AddAsync(moto);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Moto moto) {
        _context.Update(moto);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Task<Moto?> moto){
        _context.Remove(moto);
        await _context.SaveChangesAsync();
    }
}
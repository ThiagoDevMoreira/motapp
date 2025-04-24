using MotappApi.Models;
using MotappApi.Services.Interfaces;
using MotappApi.Repositories.Interfaces;

namespace MotappApi.Services;

public class MotoService : IMotoService{

    private readonly IMotoRepository _motoRepository;

    public MotoService(IMotoRepository motoRepository){
        _motoRepository = motoRepository;
    }

    public async Task<List<Moto>> GetAllAsync() =>
        await _motoRepository.GetAllAsync();
    
    public async Task<Moto?> GetByIdAsync(int id) =>
        await _motoRepository.GetByIdAsync(id);
    
    public async Task AddAsync(Moto moto) =>
        await _motoRepository.AddAsync(moto);
    
    public async Task UpdateAsync (Moto moto) =>
        await _motoRepository.UpdateAsync(moto);
    
    public async Task DeleteAsync(int id) {
        var moto = _motoRepository.GetByIdAsync(id);
        if (moto != null){
            await _motoRepository.DeleteAsync(moto);
        }
    }
}
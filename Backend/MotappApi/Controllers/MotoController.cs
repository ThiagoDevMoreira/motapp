using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using MotappApi.Models;
using MotappApi.Services;
using MotappApi.Services.Interfaces;

namespace MotappApi.Controllers{
    [ApiController]
    [Route("api/[controller]")]
    public class MotoController : ControllerBase {
        private readonly IMotoService _motoService;
        public MotoController(IMotoService motoService){
            _motoService = motoService;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Moto>>> GetAll(){
            var motos = await _motoService.GetAllAsync();
            return Ok(motos);
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Moto>> GetById(int id){
            var moto = await _motoService.GetByIdAsync(id);
            if (moto == null)
                return NotFound();
            return Ok(moto);
        }
        
        [HttpPost]
        public async Task<ActionResult<Moto>> Add(Moto moto){
            await _motoService.AddAsync(moto);
            return CreatedAtAction(nameof(GetById), new {id = moto.Id}, moto);
        }
        
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Moto moto){
            if (id != moto.Id)
                return BadRequest();    
            await _motoService.UpdateAsync(moto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id){
            await _motoService.DeleteAsync(id);
            return NoContent();
        }
    }
}
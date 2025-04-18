namespace MotappApi.Models;

public class Moto{
    public int Id {get; set;}
    public string Marca {get; set;} = string.Empty;
    public string Modelo {get; set;} = string.Empty;
    public string Placa {get; set;} = string.Empty;
    public int KmInicial {get; set;}
}
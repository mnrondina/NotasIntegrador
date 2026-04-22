// See https://aka.ms/new-console-template for more information
public class Persona
{
    private string _nombre = "";
    private string _dni ="";
    private string _apellido ="";

    public string Nombre {get => _nombre; set => _nombre = value;}
    public string dni {get => _dni; set => _dni = value;}
    public string Apellido {get => _apellido; set => _apellido = value;}

    // Faltan los métodos
    
}

public class Auto
{
    private string _patente = "";
    private string _marca ="";
    private string _modelo ="";
    private string _anio ="";
    private float _precio;

    public string Patente {get => _patente; set => _patente = value; }
    public string Marca {get => _marca; set => _marca = value;}
    public string Modelo {get => _modelo; set => _modelo = value;}
    public string Anio {get => _anio; set => _anio = value;}
    public float Precio {get => _precio; set => _precio = value;}

    
    
}


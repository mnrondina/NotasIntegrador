// See https://aka.ms/new-console-template for more information
public class Persona
{
    // Como las personas tienen autos, necesito tambien generar como atributo la LISTA DE AUTOS
    private string _nombre = "";
    private string _dni ="";
    private string _apellido ="";
    private List<Auto> _listaDeAutos;

    public string Nombre {get => _nombre; set => _nombre = value;}
    public string DNI {get => _dni; set => _dni = value;}
    public string Apellido {get => _apellido; set => _apellido = value;}

    // Constructor

    public Persona (string pNombre, string pApellido, string pDni)
    {
        _nombre = pNombre;
        _apellido = pApellido;
        _dni = pDni;
        _listaDeAutos = new List<Auto>();
    }

    // Métodos

    public List <Auto> ListaDeAutos()
    {
        return _listaDeAutos;
    }
    

    public int Cant_de_autos ()
    {
        return _listaDeAutos.Count; // Retorna la cantidad de items de la lista.
        
    }

    ~Persona ()
    {
        // acá va el mensaje finalizador.
    }
    
}

public class Auto
{
    private string _patente = "";
    private string _marca ="";
    private string _modelo ="";
    private string _anio ="";
    private decimal _precio;
    private Persona _duenio;

    public string Patente {get => _patente; set => _patente = value; }
    public string Marca {get => _marca; set => _marca = value;}
    public string Modelo {get => _modelo; set => _modelo = value;}
    public string Anio {get => _anio; set => _anio = value;}
    public decimal Precio {get => _precio; set => _precio = value;}
    public Persona Titular {get => _duenio; set => _duenio = value;}

    // Constructor

    public Auto (string aPatante, string aMarca, string aModelo, string auAño, decimal aPrecio)
    {
        _patente = aPatante;
        _marca = aMarca;
        _modelo = aModelo;
        _anio = auAño;
        _precio = aPrecio;
        _duenio = null; // Comienza en null porque no tiene dueño.
    }

    // Métodos

    public Persona Dueño ()
    {
        return _duenio;
    }

    ~Auto()
    {
        // Mensaje finalizador.
    }


    
    
}


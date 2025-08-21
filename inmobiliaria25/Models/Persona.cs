namespace inmobiliaria25.Models
{

    public abstract class Persona
    {
        public int id { get; set; }
        public string nombre { get; set; } = string.Empty;
        public string apellido { get; set; } = string.Empty;
        public string dni { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string telefono { get; set; } = string.Empty;

    }

}
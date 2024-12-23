namespace Registro_Usuario_Back.Entidad
{
    // Models/Usuario.cs
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Foto { get; set; } // Se almacenará como URL o base64
        public string ModeloEquipo { get; set; } // Modelo de la PC asignada
        public string CodigoEquipo { get; set; } // Código único de la PC
        public string Area { get; set; } // Nombre del área (ej. Sistemas, Administración)
    }
}

using System; // Importa el espacio de nombres System, necesario para funcionalidades básicas de C#.

namespace AgendaTelefonica // Define el espacio de nombres para organizar las clases relacionadas con la agenda.
{
    // [REQUISITO SEMANA 4: REGISTROS / ESTRUCTURAS]
    // Esta clase define la estructura de los datos que vamos a almacenar.
    public class Contacto // Declara la clase Contacto, que representa un contacto en la agenda.
    {
        public string NombreCompleto { get; set; } // Propiedad pública para almacenar el nombre completo del contacto.
        public string Telefono { get; set; }       // Propiedad pública para almacenar el número de teléfono.
        public string Correo { get; set; }         // Propiedad pública para almacenar el correo electrónico.
        public string Notas { get; set; }          // Propiedad pública para almacenar notas adicionales.

        // Constructor para inicializar el registro con datos
        public Contacto(string nombre, string tel, string mail, string notas) // Constructor que recibe los datos del contacto.
        {
            NombreCompleto = nombre; // Asigna el valor recibido al campo NombreCompleto.
            Telefono = tel;          // Asigna el valor recibido al campo Telefono.
            Correo = mail;           // Asigna el valor recibido al campo Correo.
            Notas = notas;           // Asigna el valor recibido al campo Notas.
        }

        // Método para facilitar la Reportería (visualización)
        public override string ToString() // Sobrescribe el método ToString para mostrar la información del contacto de forma legible.
        {
            // Devuelve una cadena formateada con los datos principales del contacto.
            return $"Nombre: {NombreCompleto,-20} | Tel: {Telefono,-10} | Mail: {Correo}";
        }
    }
}
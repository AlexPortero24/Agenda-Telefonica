using System; // Importa funcionalidades básicas de C#.
using System.IO; // Importa clases para trabajar con archivos (como StreamWriter).

namespace AgendaTelefonica // Define el espacio de nombres para organizar las clases de la agenda.
{
    public class ArchivoTxt // Declara la clase ArchivoTxt, encargada de la gestión de archivos de texto.
    {
        // Guarda la lista de contactos en un archivo de texto
        public void GuardarEnDisco(Contacto[] contactos) // Método público que recibe un arreglo de contactos y los guarda en un archivo.
        {
            using (StreamWriter sw = new StreamWriter("BaseDeDatos.txt")) // Crea un StreamWriter para escribir en el archivo "BaseDeDatos.txt". El 'using' asegura que el archivo se cierre correctamente al terminar.
            {
                foreach (var contacto in contactos) // Recorre cada contacto en el arreglo recibido.
                {
                    // Escribe una línea en el archivo con los datos del contacto, separados por '|'.
                    sw.WriteLine($"{contacto.NombreCompleto}|{contacto.Telefono}|{contacto.Correo}|{contacto.Notas}");
                }
            } // Al salir del bloque 'using', el archivo se cierra automáticamente.
        }
    }
}
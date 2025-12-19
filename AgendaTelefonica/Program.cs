using System; // Importa funcionalidades básicas de C#, como entrada/salida por consola.

namespace AgendaTelefonica // Define el espacio de nombres para organizar las clases de la agenda.
{
    class Program // Declara la clase principal del programa.
    {
        static void Main(string[] args) // Método principal, punto de entrada del programa.
        {
            // Instancia de nuestras clases (Programación Orientada a Objetos)
            GestionDeDatos logica = new GestionDeDatos(); // Crea un objeto para gestionar los contactos en memoria.
            ArchivoTxt persistencia = new ArchivoTxt();    // Crea un objeto para guardar los contactos en un archivo.
            bool ejecutando = true; // Variable de control para mantener el ciclo principal activo.

            while (ejecutando) // Bucle principal del programa, se repite hasta que el usuario decida salir.
            {
                Console.Clear(); // Limpia la pantalla de la consola para mejor presentación.
                Console.WriteLine("======= SISTEMA DE AGENDA TELEFÓNICA (POO) ======="); // Muestra el título del sistema.
                Console.WriteLine("1. Registrar Contacto (Llenar Vector)"); // Opción para registrar un nuevo contacto.
                Console.WriteLine("2. Ver Reportería (Consultar Vector)");  // Opción para ver los contactos almacenados.
                Console.WriteLine("3. Respaldar en archivo (.txt)");        // Opción para guardar los contactos en un archivo.
                Console.WriteLine("4. Salir");                              // Opción para salir del programa.
                Console.Write("\nSeleccione una opción: "); // Solicita al usuario que elija una opción.

                string opcion = Console.ReadLine(); // Lee la opción ingresada por el usuario.

                switch (opcion) // Evalúa la opción seleccionada.
                {
                    case "1": // Si elige registrar un contacto.
                        Console.Write("Nombre Completo: "); string n = Console.ReadLine(); // Solicita y lee el nombre.
                        Console.Write("Teléfono: "); string t = Console.ReadLine();        // Solicita y lee el teléfono.
                        Console.Write("Correo Electrónico: "); string e = Console.ReadLine(); // Solicita y lee el correo.
                        Console.Write("Notas adicionales: "); string nt = Console.ReadLine(); // Solicita y lee notas adicionales.

                        // Creamos el registro y lo enviamos a la gestión de datos
                        if (logica.AgregarAlVector(new Contacto(n, t, e, nt))) // Intenta agregar el nuevo contacto al vector.
                            Console.WriteLine("\n[EXITO] Registro almacenado en el Vector."); // Mensaje si se agregó correctamente.
                        else
                            Console.WriteLine("\n[ERROR] Capacidad del Vector agotada."); // Mensaje si el vector está lleno.
                        break;

                    case "2": // Si elige ver la reportería.
                        Console.WriteLine("\n--- REPORTERÍA DE LA ESTRUCTURA DE DATOS ---"); // Título de la sección de reportería.
                        var lista = logica.ObtenerLista(); // Obtiene la lista de contactos almacenados.
                        if (lista.Length == 0) Console.WriteLine("Agenda vacía."); // Si no hay contactos, lo indica.
                        foreach (var contacto in lista) // Recorre cada contacto en la lista.
                        {
                            Console.WriteLine(contacto.ToString()); // Muestra la información del contacto.
                        }
                        break;

                    case "3": // Si elige respaldar en archivo.
                        persistencia.GuardarEnDisco(logica.ObtenerLista()); // Llama al método para guardar los contactos en un archivo.
                        Console.WriteLine("\n[OK] Datos guardados en BaseDeDatos.txt"); // Mensaje de confirmación.
                        break;

                    case "4": // Si elige salir.
                        ejecutando = false; // Cambia la variable de control para salir del bucle.
                        break;

                    default: // Si ingresa una opción no válida.
                        Console.WriteLine("Opción no válida."); // Informa al usuario que la opción no es válida.
                        break;
                }
                Console.WriteLine("\nPresione cualquier tecla para continuar..."); // Mensaje para pausar antes de limpiar la pantalla.
                Console.ReadKey(); // Espera a que el usuario presione una tecla.
            }
        }
    }
}
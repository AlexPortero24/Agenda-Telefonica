using System; // Importa funcionalidades básicas de C#, como el manejo de arreglos.

namespace AgendaTelefonica // Define el espacio de nombres para organizar las clases de la agenda.
{
    public class GestionDeDatos // Declara la clase GestionDeDatos, que administra los contactos en memoria.
    {
        // [REQUISITO SEMANA 4: VECTORES]
        // Creamos un vector (arreglo unidimensional) de objetos tipo Contacto con capacidad para 50.
        private Contacto[] vectorContactos = new Contacto[50]; // Arreglo privado para almacenar hasta 50 contactos.

        // Contador para saber cuántos espacios del vector hemos llenado
        private int contadorIndices = 0; // Lleva la cuenta de cuántos contactos hay realmente en el arreglo.

        // ACCIÓN: Insertar un nuevo registro en el vector
        public bool AgregarAlVector(Contacto nuevo) // Método público para agregar un nuevo contacto al arreglo.
        {
            // Validamos que la estructura de datos no esté llena
            if (contadorIndices < vectorContactos.Length) // Si aún hay espacio en el arreglo...
            {
                vectorContactos[contadorIndices] = nuevo; // ...agrega el nuevo contacto en la posición disponible.
                contadorIndices++; // Incrementa el contador para la próxima inserción.
                return true; // Indica que la operación fue exitosa.
            }
            return false; // Retorna falso si el vector llegó a su límite.
        }

        // [REQUISITO: REPORTERÍA]
        // ACCIÓN: Consultar y listar todos los elementos actuales del vector
        public Contacto[] ObtenerLista() // Método público para obtener solo los contactos registrados.
        {
            // Retornamos solo los datos registrados para no mostrar espacios vacíos
            Contacto[] listaActiva = new Contacto[contadorIndices]; // Crea un nuevo arreglo del tamaño exacto de los contactos registrados.
            Array.Copy(vectorContactos, listaActiva, contadorIndices); // Copia solo los contactos existentes al nuevo arreglo.
            return listaActiva; // Devuelve el arreglo con los contactos activos.
        }
    }
}
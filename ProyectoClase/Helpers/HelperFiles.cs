using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClase.Helpers {
    public class HelperFiles {
        //METODO PARA LEEER FICHEROS
        //ESTE METODO DEVUELVE EL STRING DEL FILE
        //EN LAS CLASES, LOS METODOS ASINCRONOS
        //UTILIZAN LA CLASE Task PARA SU DECLARACION
        //SI ES UN void, SIMPLEMENTE SE UTILIZA LA PALBRA Task
        //SI ES UN return, SE UTILIZA Task<Tipo>
        public static async Task<string> ReadFileAsync(string path) {
            FileInfo file = new FileInfo(path);
            //PARA LEER VAMOS A UTILIZAR using
            //PARA ASEGURARNOS QUE DENTRO DEL CODIGO
            //EL OBJETO SIEMPRE ESTARA ACCESIBLE
            string contenido = "";
            using (TextReader reader = file.OpenText()) {
                //DENTRO DE ESTE CODIGO DEBEMOS UTILIZAR READER
                //Y DESOUES QUEDARA DESTRUIDO
                contenido = await reader.ReadToEndAsync();
                reader.Close();
            }
            return contenido;
        }

        //METODO PARA ESCRIBIR EN UN FILE
        //ESTE METODO ES DE ACCIÓN (void)
        //NO DEVUELVE NADA
        public static async Task WriteFileAsync(string path, string data) {
            FileInfo file = new FileInfo(path);
            using (TextWriter writer = file.CreateText()) {
                //EL CONTENIDO QUE DESEAMOS ESCRIBIR ESTA
                //EN EL LISTBOX
                await writer.WriteAsync(data);
                //SIEMPRE QUE TRABAJEMOS CON FILES, AL ESCRIBIR,
                //DEBEMOS TERMINAR CON EL METODO FLUSH DEPUES DE 
                //ESCRIBIR
                await writer.FlushAsync();
                writer.Close();
            }
        }
    }
}

using ProyectoClase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClase.Helpers {
    public class HelperMascotas {

        #region PROPIEDADES
        public List<Mascota> Mascotas { get; set; }
        #endregion

        #region CONSTRUCTOR
        public HelperMascotas() {
            this.Mascotas = new List<Mascota>();
        }
        #endregion

        #region METODOS
        //TENDREMOS METODOS QUE SERAN LAS TRIPAS DE LA CLASE
        //VAMOS A LEER UN FILE Y CONTENDRA UN TEXTO CON LAS MASCOTAS
        private void CreateMascotas(string data) {
            //LIMPIAMOS LA COLECCION
            this.Mascotas.Clear();
            //SEPARAMOS LOS OBJETOS
            string[] datosmascotas = data.Split(',');
            foreach (string datosma in datosmascotas) {
                //SEPARAMOS CADA PROPIEDAD
                string[] propiedades = datosma.Split("#");
                //INSTANCIAMOS OBJETO MASCOTA
                Mascota mascota = new Mascota();
                mascota.Nombre = propiedades[0];
                mascota.Raza = propiedades[1];
                this.Mascotas.Add(mascota);
            }
        }

        //CUANDO LEAMOS EL FICHERO DE MASCOTAS, LAS CREAREMOS
        //NECESITAMOS LA RUTA
        public async Task ReadFileMascotasAsync(string path) {
            //EXTRAEMOS EL CONTENIDO DEL FICHERO
            string data = await HelperFiles.ReadFileAsync(path);
            this.CreateMascotas(data);
        }

        //AL ESCRIBIR VAMOS A DIBUJAR TODAS LAS MASCOTAS
        //CON LOS SEPARADORES QUE HEMOS UTILIZADO
        private string GetMascotasString() {
            string data = "";
            //RECORREMOS LA COLECCION LIST<Mascota>
            //Y LE DAMOS FORMATO STRING
            foreach (Mascota mascota in this.Mascotas) {
                string temp = mascota.Nombre + "#" + mascota.Raza;
                data += temp + ",";
            }
            data = data.Trim(',');
            return data;
        }

        public async Task SaveFileMascotasAsync(string path) {
            string data = this.GetMascotasString();
            await HelperFiles.WriteFileAsync(path, data);
        }
        #endregion
    }
}

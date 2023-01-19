using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClase {
    #region ENUMERACIONES
    public enum TipoGenero { Masculino, Femenino }
    public enum Paises { España, Italia, Francia, Brasil }
    #endregion
    public class Persona {

        public Persona() {
            this.DomicilioVacaciones = new Direccion("Mundo", "Islas Feroe");
        }

        #region CAMPOS DE PROPIEDAD
        //EN LAS PROPIEDADES SE UTILIZAN
        //CAMPOS PRIVADOS PARA LOS VALORES DE LA PROPIEDAD
        private int _Edad;
        #endregion

        #region PROPIEDADES
        public int Edad {
            get {
                //DEVOLVER EL VALOR DEL CAMPO
                return this._Edad;
            }
            set {
                //AQUI DESEAMOS COMPROBAR EL DATO QUE VIEN
                //DENTRO DE Value
                if (value < 0) {
                    throw new Exception("La edad no puede ser negativa");
                } else {
                    this._Edad = value;
                }
            }
        }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public TipoGenero Genero { get; set; }
        public Paises Nacionalidad { get; set; }
        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }
        #endregion

        #region METODOS
        public string GetNombreCompleto() {
            return this.Nombre + " " + this.Apellidos;
        }
        //QUEREMOS DEVOLVER EL NOMBRE EN ORDEN INVERSO
        public string GetNombreCompleto(bool orden) {
            if (orden) {
                return this.Apellidos + " " + this.Nombre;
            } else {
                return this.GetNombreCompleto();
            }
        }
        public void MetodoParametrosOpcionales(int num1, int num2 = 199, int num3 = 11) {

        }
        #endregion
    }
}

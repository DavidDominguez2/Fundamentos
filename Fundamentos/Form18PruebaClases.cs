using ProyectoClase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos {
    public partial class Form18PruebaClases : Form {
        public Form18PruebaClases() {
            InitializeComponent();
        }

        private void btnData_Click(object sender, EventArgs e) {
            Persona persona = new Persona();

            persona.Nombre = "Alumno";
            persona.Domicilio = new Direccion("Av. Los Perales", "Madrid", 28019);

            this.lstPersons.Items.Add("Nombre: " + persona.Nombre);
            this.lstPersons.Items.Add("Direccion: " + persona.Domicilio.Calle);
            this.lstPersons.Items.Add("Direccion Vacaciones: " + persona.DomicilioVacaciones.Calle);



            persona.Apellidos = "Desarrollo";
            persona.Edad = 21;
            persona.Nacionalidad = Paises.Italia;
            persona.Genero = TipoGenero.Femenino;

            persona.MetodoParametrosOpcionales(77);
            persona.MetodoParametrosOpcionales(77, 99);
            //SOLO QUIERO ENVIAR LA TERCERA OPCIÓN
            persona.MetodoParametrosOpcionales(1, num3: 3);


            this.lstPersons.Items.Add(persona.Nombre + " " + persona.Apellidos + " , EDAD: " + persona.Edad);
            this.lstPersons.Items.Add(persona.Genero + ", " + persona.Nacionalidad);
            this.lstPersons.Items.Add(persona.GetNombreCompleto());
            this.lstPersons.Items.Add(persona.GetNombreCompleto(true));


        }

        private void btnEmpleado_Click(object sender, EventArgs e) {
            //Empleado empleado = new Empleado();
            //empleado.Nombre = "David";
            //empleado.Apellidos = "Dominguez";
            //this.lstPersons.Items.Add(empleado.GetNombreCompleto() + ", Vacaciones: " + empleado.GetDiasVacaciones());

            Director director = new Director();
            director.Nombre = "Director";
            director.Apellidos = "Director";
            this.lstPersons.Items.Add(director.GetNombreCompleto() + ", Vacaciones: " + director.GetDiasVacaciones());
            this.lstPersons.Items.Add(director);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos2
{
    //ATRIBUTOS:Nombre, nacionalidad.
    class Persona
    {
        private string nombre;
        private string nacionalidad;

        public Persona( string nombre, string nacionalidad)
        {
            this.nombre = nombre;
            this.nacionalidad = nacionalidad;
        }
          public string Nacionalidad
        {
            get { return nacionalidad; }
        }

   //METODOS: SALUDAR
        public string saludar()
        {
            return "Hola soy..." + nombre;
        }
  //SOBRE CARGA DE METODO
       public string saludar(string personaje)
        {
            return "Hola " + personaje + ", soy" + nombre;
        }
    }
}

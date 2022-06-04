using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Animales
    {
        //ID; Nombre, Especie, Fecha Creación, Fecha modificación, Eliminado = true / false.
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool Eliminado { get; set; }

        public Animales(int iD, string nombre, string especie, DateTime fechaModificacion)
        {
            ID = iD; //hacer autonumerico
            Nombre = nombre; //Obligatorio
            Especie = especie; //Obligatorio
            FechaCreacion = DateTime.Now; 
            FechaModificacion = fechaModificacion;
            Eliminado = false;
        }
    }
}

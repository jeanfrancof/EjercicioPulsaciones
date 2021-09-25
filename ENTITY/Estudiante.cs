using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estudiante
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public int Pulsos { get; set; }

        public Estudiante(string identificacion, string nombre, int edad, string sexo)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
        }

        public void CalcularPulsosEstudiantes()
        {
            if (Sexo == "f")
            {
                Pulsos = (220 - Edad) / 10;
            }
            else if (Sexo == "m")
            {
                Pulsos = (210 - Edad) / 10;
            }
            else
            {
                Pulsos = 0;
            }
        }

        public override string ToString()
        {
            return $"Identidad: {Identificacion} \nNombre {Nombre} \nEdad: {Edad} \nSexo: {Sexo}  \nPulsos: {Pulsos}";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace PersistenciaDatos
{
    public class EstudianteRepositorio
    {

        public List<Estudiante> ListaEstudiantes = new List<Estudiante>();

        public void Guardar(Estudiante estudiante)
        {
            ListaEstudiantes.Add(estudiante);
        }

        public void Eliminar(Estudiante estudiante)
        {
            ListaEstudiantes.Remove(estudiante);
        }

        public List<Estudiante> Consultar()
        {
            return ListaEstudiantes;
        }

        public void Modificar(Estudiante estudiante)
        {
            Estudiante estudianteEliminar = Buscar(estudiante.Identificacion);
            Eliminar(estudianteEliminar);
            Guardar(estudiante);
        }

        public Estudiante Buscar(Estudiante estudiante)
        {
            foreach (var item in ListaEstudiantes)
            {
                if (item.Identificacion.Equals(estudiante.Identificacion))
                {
                    return item;
                }
            }
            return null;
        }

        public Estudiante Buscar(string identificacion)
        {
            foreach (var item in ListaEstudiantes)
            {
                if (item.Identificacion.Equals(identificacion))
                {
                    return item;
                }
            }
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using PersistenciaDatos;

namespace LogicaNegocio
{
    public class EstudianteService
    {
        EstudianteRepositorio estudianteRepositorio = new EstudianteRepositorio();
        public string Guardar(Estudiante estudiante)
        {
            if (estudianteRepositorio.Buscar(estudiante) == null)
            {
                estudianteRepositorio.Guardar(estudiante);
                return $"Se registro el estudiante {estudiante.Identificacion} Satisfactoriamente";
            }
            else
            {
                return $"El estudiante {estudiante.Identificacion} ya esta registrado";
            }


        }

        public string Eliminar(Estudiante estudiante)
        {
            if (estudianteRepositorio.Buscar(estudiante) == null)
            {

                return $"El estudiante con la cedula no se encuentra registrado";

            }
            else
            {
                estudianteRepositorio.Eliminar(estudiante);
                return $"El estudiante {estudiante.Identificacion} fue eliminado";
            }
        }

        public List<Estudiante> Consultar()
        {
            return estudianteRepositorio.Consultar();
        }

        public string Modificar(Estudiante estudiante)
        {
            if (estudianteRepositorio.Buscar(estudiante) == null)
            {

                return $"El estudiante con identificacion no se encuentra registrado satisfactoriamente";

            }
            else
            {
                estudianteRepositorio.Modificar(estudiante);
                return $"El estudiante {estudiante.Identificacion} fue Modificado con exito";
            }
        }

        public Estudiante Buscar(string identificacion)
        {
            return estudianteRepositorio.Buscar(identificacion);
        }
    }
}

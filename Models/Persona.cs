using System;

namespace ProyFinJBarboza
{
    public abstract class Persona
    {
        private int _id;
        private string _nombre;
        private int _dni;

        public Persona() { }

        public Persona(int id, string nombre, int dni)
        {
            _id = id;
            _nombre = nombre;
            _dni = dni;
        }

        public void setId(int id)
        {
            _id = id;
        }

        public void setNombre(string nombre, string apellido)
        {
            _nombre = nombre + ", " + apellido;
        }

        public void setDni(int dni)
        {
            _dni = dni;
        }

        public int getId()
        {
            return _id;
        }

        public string getNombre()
        {
            return _nombre;
        }

        public int getDni()
        {
            return _dni;
        }

    }
}
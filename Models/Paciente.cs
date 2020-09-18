using System;

namespace ProyFinJBarboza
{
    public class Paciente : Persona
    {

        private int _estado;
        public Paciente(int id, string nombre, int dni, int estado) : base(id,nombre, dni) {
            this._estado = estado;
        }

        public int getestado() {
            return this._estado;
        }

    }
}
using System;

namespace ProyFinJBarboza
{
    public class Sala
    {
        private int _id;
        private string _nombre;

        public Sala(){}

        public Sala(int id,
                    string nombre) {
            this._id = id;
            this._nombre = nombre;
        }
        
        public int getId() {
            return this._id;
        }

        public string getNombre() {
            return this._nombre;
        }
    }
}
using System;
using System.Collections.Generic;

namespace ProyFinJBarboza
{
    public class Medico : Persona
    {
        private List<Paciente> _Pacientes;
        private Sala _Sala;

        public Medico(){}
        
        public Medico(int id, string nombre, int dni, Sala Sala) : base(id, nombre, dni) {
            this._Pacientes = new List<Paciente>();
            this._Sala = Sala;
        }

        public void addPaciente(Paciente Paciente) {
            this._Pacientes.Add(Paciente);
        }

        public List<Paciente> getPacientes() {
            return this._Pacientes;
        }

        public Sala getSala() {
          return this._Sala;  
        } 

    }
}
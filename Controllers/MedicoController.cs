using System;

namespace ProyFinJBarboza
{
    public static class MedicoController
    {
        public static bool findAllMedico() {
            
            return true;

        }

        public static Medico findMedicoById(int id) {
            Conexion cn = new Conexion();

            if(id == 0) {
                throw new Exception();
            }

            Medico Medico = cn.getMedicoeById(id);
            return Medico;
        }
        public static bool saveMedico(Medico Medico) {
            
            if(Medico.getNombre().Length == 0 && Medico.getId() == 0) {
                throw new Exception("Los datos estan vacios");
            }

            return true;

        }

        public static bool updateMedico(Medico Medico) {
            
            return true;

        }

        public static bool deleteMedico(Medico Medico) {
            
            return true;

        }

    }
}
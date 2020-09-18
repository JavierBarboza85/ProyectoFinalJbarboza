using System;
using System.Collections.Generic;

namespace ProyFinJBarboza
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos Salas
            Sala s1 = new Sala(1, "Traumatologia");
            Sala s2 = new Sala(2, "Cardiologia");

            // Creamos Pacientes
            Paciente Luis = new Paciente(1,"Luis Perez",25534897,0);
            Paciente Jose = new Paciente(2,"Jose Diaz", 16435742, 0);

            // Creamos Medicos
            Medico Santiago = new Medico(1,"Santiago Garcia",14345876,s1);
            Medico Agustin = new Medico(2,"Agustin Decima",38652010,s2);

            // Asignamos Pacientes a Medico
            Santiago.addPaciente(Luis);
            Santiago.addPaciente(Jose);
            
            // creamos arreglo de personas
            Persona[] personas = {Luis, Jose, Santiago, Agustin};

            Conexion cn = new Conexion();
            Medico p1 = MedicoController.findMedicoById(2);

            Console.WriteLine("---- get Medico by id -----");
            Console.WriteLine(p1.getId());
            Console.WriteLine(p1.getNombre());
            Console.WriteLine(p1.getDni());
            Console.WriteLine("------------------");

            List<Medico> Medicos = cn.getAllMedicos();
            
            Console.WriteLine("---- get all Medicos ----");
            foreach (var Medico in Medicos)
            {
                Console.WriteLine(Medico.getId());
                Console.WriteLine(Medico.getNombre());
                Console.WriteLine(Medico.getDni());
            }

             //for (int i = 0; i < Medicos.Count; i++)
             //{
             //    Console.WriteLine(Medicos[i].getId());
             //    Console.WriteLine(Medicos[i].getNombre());
             //    Console.WriteLine(Medicos[i].getDni());
             //}

            Medico p3 = new Medico();
            p3.setNombre("asdads","aasd");
            p3.setId(2);
            MedicoController.saveMedico(p3);


        }
    }
}

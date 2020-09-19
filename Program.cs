using System;
using System.Collections.Generic;

namespace ProyFinJBarboza
{
    class Program
    {
        static void Main(string[] args)
        {

            Conexion cn = new Conexion();
            Medico p1 = MedicoController.findMedicoById(2);

            Console.WriteLine("---- Mostrar Medico por id -----");
            Console.WriteLine(p1.getId());
            Console.WriteLine(p1.getNombre());
            Console.WriteLine(p1.getDni());
            Console.WriteLine("------------------");

            List<Medico> Medicos = cn.getAllMedicos();
            
            Console.WriteLine("---- Mostrar todos los Medicos ----");
            foreach (var Medico in Medicos)
            {
                Console.WriteLine(Medico.getId());
                Console.WriteLine(Medico.getNombre());
                Console.WriteLine(Medico.getDni());
            }


            Medico p4 = new Medico();
            p4.setNombre("Julio","Diaz");
            p4.setId(4);
            MedicoController.saveMedico(p4);


        }
    }
}

using System.Runtime.ConstrainedExecution;
using System.Security.AccessControl;
using System.Security.Cryptography;
using libreriaClases;

namespace libreriaClases{
    class Persona{


        public string Apellido {get; set;}
        public string Nombre {get; set;}
        public int DNI {get; set;}
        public string fechaNacimiento {get; set;}





  
        public Persona(string rnombre, string rfechaNacimiento, int rdni, string rapellido){
           Apellido = rapellido;
           Nombre = rnombre;
           fechaNacimiento = rfechaNacimiento;
           DNI = rdni;



        }
 
        public Persona(){

        }
    
        public int devolverEdad(){
            return 2;
        }

       
        public string caminar(){
            return "caminando";
        }
         
            

        public void mostrarPersona(){
            
            Console.WriteLine("apellido: {0}", Apellido);

           Console.WriteLine("nombre: {0}", Nombre);
           Console.WriteLine("fechadeNacimiento: {0}", fechaNacimiento);
            Console.WriteLine("dni: {0}", DNI);
        }
    }
}


    class Alumno : Persona{

        private int legajo;
        private string curso;
        private int[] notas;

        public void estudiar(){
            Console.WriteLine("Estudiando");
        }
         public int devolverCurso(){
            return 6;
        }
}
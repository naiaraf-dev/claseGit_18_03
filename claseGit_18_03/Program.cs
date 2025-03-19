namespace claseGit_18_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    /*
     PROCEDIMIENTO GIT:
     (repositorio)
     1- git init (solo cuando se inicializa)
     -- bucle de trabajo --
     2- git add
     3- git commit -m "msj referencial a lo que voy a subir"
     - (repositorio REMOTO) -
     4- git push (ENVIAR LOS CAMBIOS)
     -----------------------------------
     5- git pull (TRAERME LOS CAMBIOS)
    */ 


    public class Pokemon
    {
        //Atributos
        public string nombre;
        public int salud;
        public string raza;


        //Metodos
        public void Atacar()
        {
            Console.WriteLine("Ataco!");
        }

        public void Defender()
        {
            Console.WriteLine("Activo defensa");
        }
    }
}

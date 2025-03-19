namespace claseGit_18_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

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

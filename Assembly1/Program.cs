namespace Assembly1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual é o teu primeiro nome? ");

            string firstName = Console.ReadLine();

            Console.WriteLine("Qual é o teu segundo nome? ");
            string middleName = Console.ReadLine();

            Console.WriteLine("Qual é o teu último nome? ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Qual é o teu nome completo? ");
            string fullName = Console.ReadLine();

            Console.WriteLine("Qual é o teu gênero? ");
            string genero = Console.ReadLine();

            Console.WriteLine("Qual é a sua idade? ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o seu ano de nascimento? ");
            int nasc = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é seu trabalho atual? ");
            string trabalho = Console.ReadLine();


            Console.WriteLine("Qual é sua altura? ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a cor dos seus olhos? ");
            string olho = Console.ReadLine();

            Console.WriteLine($"My full name is {firstName} {middleName} {lastName}");

            DateTime dataAtual = DateTime.Now;

            int idade = DateTime.Now.Year - nasc;

            Console.WriteLine($"A sua idade é: {idade}");



        }
    }
}
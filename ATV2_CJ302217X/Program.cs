namespace ATV2_CJ302217X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario;


            //Leitura do salario
            Console.WriteLine("Entre com o seu salario: ");
            salario = float.Parse( Console.ReadLine() );

            salario = salario + (25.0f/ 100.0f) *salario;

            Console.WriteLine("O novo salário é R$ {0}", salario);
        }
    }
}

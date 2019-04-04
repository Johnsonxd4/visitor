using System;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var johnson = new UsuarioUber("johnson", "minha casa", "HBSIS", "Alagoinha");
            var higor = new UsuarioUber("higor", "casa do higor", "HBSIS", "android studio");
            var valdir = new UsuarioUber("valdir","casa do valdir", "HBSIS", "animeinga");

            var uber = new AplicativoUber();

            uber.Attach(johnson);
            uber.Attach(higor);
            uber.Attach(valdir);


            Console.WriteLine("Está na hora de ir pra casa?");
            Console.ReadKey();

            var meLevaPraCasa = new MeLevaPraCasa();
            uber.Accept(meLevaPraCasa);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Está na hora de ir para o trabalho?");
            Console.ReadKey();

            var meLevaProTrabalho = new MeLevaProTrabalho();
            uber.Accept(meLevaProTrabalho);
            Console.ReadKey();
        }
    }
}

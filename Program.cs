using System.ComponentModel.Design;

internal class Program
{

    private static void Main(string[] args)
    {
        bool hratZnovu = true;
        while(hratZnovu)
        {
            Hra();
            Console.WriteLine("Chceš si zahrát znovu? ano/ne");
            string odpoved = Console.ReadLine();
            hratZnovu = (odpoved.ToLower() == "ano");
        }
        Console.WriteLine("Děkuji za hraní.Stiskni libovolnou klávesu pro ukončení programu.");
        Console.ReadKey();
    }
    static void Hra()
    {
        Random random = new Random();
        int VybraneCislo = random.Next(1, 101);
        bool uhodnuto = false;
        string pokracovat = "ano";

        while (!uhodnuto)
        {
            Console.WriteLine("Uhádni číslo, které si myslím");
            string vstup = Console.ReadLine();
          
            if (int.TryParse(vstup, out int tip))
            {
                int rozdil = Math.Abs(tip - VybraneCislo);

                if (rozdil == 0)
                {
                    Console.WriteLine("Gratuluji, uhodnuto");
                    uhodnuto = true;
                }
                else if (rozdil <= 5)
                {
                    Console.WriteLine("Jsi blízko");
                }
                else if (tip < VybraneCislo)
                {
                    Console.WriteLine("Bylo zadáno menší číslo");
                }
                
                else
                {
                    Console.WriteLine("Bylo zadáno větší číslo");
                }
            }
            else { Console.WriteLine("Neplatný vstup"); }

        }
       
    }
}

    class Program
{
    static void Main(string[] args)
    {
        Random losowa = new Random();
        bool zagrajPonownie = true;
        int min = 1;
        int max = 10;
        int zgaduj;
        int numer;
        int domysł;
        String response;

        while (zagrajPonownie)
        {
            zgaduj = 0;
            domysł = 0;
            response = "";
            numer = losowa.Next(min, max + 1);
            while (zgaduj != numer)
            {
                Console.WriteLine("zganij liczbę pimiędzy" + min + " - " + max + " : ");
                zgaduj = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("zgaduj: " + zgaduj);

                if (zgaduj > numer)
                {
                    Console.WriteLine(zgaduj + "jest za wysoka!");
                }
                else if (zgaduj < numer)
                {
                    Console.WriteLine(zgaduj + " jest za mała!");
                }
                domysł++;
            }
            Console.WriteLine("Numer:" + numer);
            Console.WriteLine("Wygrałeś Brawo");
            Console.WriteLine("Zgaduj" + zgaduj);

            Console.WriteLine("Chcesz zagrać ponownie (T/N)");
            response = Console.ReadLine();
            response = response.Trim();

            if (response == "T")
            {
                zagrajPonownie = true;
            }
            else
            {
                zagrajPonownie = false;
            }


        }
        Console.WriteLine("Dzięki za grę");

        Console.ReadKey();


    }
}

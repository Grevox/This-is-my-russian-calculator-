

class onenenenenene
{
    public static void Main(String[]args)
    {


        Console.WriteLine("welcome Comrade to the Russian calculator");
        Console.WriteLine("chos de operation type. press entr to strt!");
        Console.ReadLine();
        Console.WriteLine("chos betwin addition [a] subtraction[s] multiplication[m] division[d]  reminder[r]");
        string Choose = Console.ReadLine();
        if (Choose == "a")
        {
            Console.WriteLine("welkome C0mr4d3 . Yu ned to chos two numbars. her, chos");
            string Comrade1 = Console.ReadLine();
            string Comrade2 = Console.ReadLine();
            long Comrade = System.Convert.ToInt64(Comrade1);
            long Comradee = System.Convert.ToInt64(Comrade2);
            long CAZZO = Comrade + Comradee;
            Console.WriteLine("her ar de results " + CAZZO);
        }
        if (Choose == "s")
        {
            Console.WriteLine("welkome C0mr4d3 . Yu ned to chos two numbars. her, chos");
            string Comrade1 = Console.ReadLine();
            string Comrade2 = Console.ReadLine();
            long Comrade = System.Convert.ToInt64(Comrade1);
            long Comradee = System.Convert.ToInt64(Comrade2);
            long CAZZO = Comrade - Comradee;
            Console.WriteLine("her ar de results " + CAZZO);
        }
        if (Choose == "m")
        {
            Console.WriteLine("welkome C0mr4d3 . Yu ned to chos two numbars. her, chos");
            string Comrade1 = Console.ReadLine();
            string Comrade2 = Console.ReadLine();
            long Comrade = System.Convert.ToInt64(Comrade1);
            long Comradee = System.Convert.ToInt64(Comrade2);
            long CAZZO = Comrade * Comradee;
            Console.WriteLine("her ar de results " + CAZZO);
        }
        if (Choose == "d")
        {
            Console.WriteLine("welkome C0mr4d3 . Yu ned to chos two numbars. her, chos");
            string Comrade1 = Console.ReadLine();
            string Comrade2 = Console.ReadLine();
            long Comrade = System.Convert.ToInt64(Comrade1);
            long Comradee = System.Convert.ToInt64(Comrade2);
            long CAZZO = Comrade / Comradee;
            Console.WriteLine("her ar de results " + CAZZO);

        }
        if (Choose == "r")
        {
            Console.WriteLine("welkome C0mr4d3 . Yu ned to chos two numbars. her, chos");
            string Comrade1 = Console.ReadLine();
            string Comrade2 = Console.ReadLine();
            long Comrade = System.Convert.ToInt64(Comrade1);
            long Comradee = System.Convert.ToInt64(Comrade2);
            long CAZZO = Comrade % Comradee;
            Console.WriteLine("her ar de results " + CAZZO);
        }




    }



}


namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("AMalni kiriting : ");
                string amal = Console.ReadLine();      
                if (amal.Contains("+"))
                {
                    string[] sonlar = amal.Split('+');
                    Console.WriteLine(int.Parse(sonlar[0]) + int.Parse(sonlar[1]));

                }
                else if (amal.Contains("-"))
                {
                    string[] sonlar = amal.Split('-');
                    Console.WriteLine(int.Parse(sonlar[0]) - int.Parse(sonlar[1]));
                }
                else if (amal.Contains("*"))
                {
                    string[] sonlar = amal.Split('*');
                    Console.WriteLine(int.Parse(sonlar[0]) * int.Parse(sonlar[1]));
                }
                else if (amal.Contains("/"))
                {
                    string[] sonlar = amal.Split('/');
                    Console.WriteLine(int.Parse(sonlar[0]) / int.Parse(sonlar[1]));
                }
                else if (!amal.Contains("%"))
                {
                    string[] sonlar = amal.Split('%');
                    Console.WriteLine(int.Parse(sonlar[0]) % int.Parse(sonlar[1]));
                }
                else if (amal.Contains("^"))
                {
                    string[] sonlar = amal.Split('^');
                    Console.WriteLine(int.Parse(sonlar[0]) ^ int.Parse(sonlar[1]));
                }
                Console.WriteLine("<- TUGATISH     DAVOM ETISH->");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    continue;
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    break;
                }

            }
        }
    }
}

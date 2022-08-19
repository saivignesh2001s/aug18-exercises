namespace Aug18Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            string s="14";
            bool res;
            res=Int32.TryParse(s, out a);
            Console.WriteLine(res);
            Console.WriteLine(a);
            int i;
            for (i = 0; i < 4; i++)
            {
                int g = 0;
                for (g = 0; g < 4; g++)
                {
                    if(i%2==0)
                    Console.Write(a);
                    else
                        Console.Write("{0} ",a);
                }
                Console.Write("\n");
                
            }
            Console.ReadLine();
        }
    }
}
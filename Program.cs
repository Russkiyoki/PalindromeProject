namespace Project
{
    //project for CSE101 Clark College
    //checks if input is the same reversed
    public class Program
    {
        static public bool isPali;
        public static string input;
        static void Main(string[] args)
        {
            input = Console.ReadLine();
            bool isPali = IsPali(input);
            Console.WriteLine(isPali);
        }
        static public bool IsPali(string inp)
        {
            char[] charArray = inp.ToCharArray();
            Array.Reverse(charArray);
            string reversedInput = new string(charArray);

            if(inp == reversedInput)
            {
                isPali = true;
            }
            else
            {
                isPali = false;
            }
            //Console.WriteLine(isPali);

            return isPali;
        }
    }
}
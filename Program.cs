namespace Interface
{
    public class Program:IMethod
    {
        public static void Main()
        {
            Program program = new Program();
            program.Calculate(5, 29);
        }

        public void Calculate(int a, int b)
        {
           int sum = 0;
            sum = a + b;
            Console.WriteLine(sum);
        }
    }
}
namespace GenericC___eps_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<int> boxInt = new Box<int>();
            boxInt.Content = 5;
            Console.WriteLine(boxInt.Log());

            Box<string> boxString = new Box<string>();
            boxString.Content = "HIAAAA";
            Console.WriteLine(boxString.Log());
        }
    }
}

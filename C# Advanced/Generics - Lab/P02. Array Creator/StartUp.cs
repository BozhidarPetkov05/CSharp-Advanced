namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] array = ArrayCreator.Create(300, "Gosho");
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
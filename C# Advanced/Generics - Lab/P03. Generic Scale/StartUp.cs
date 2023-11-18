namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> equalityScale = new EqualityScale<int>(5,6);
            Console.WriteLine(equalityScale.AreEqual());
        }
    }
}
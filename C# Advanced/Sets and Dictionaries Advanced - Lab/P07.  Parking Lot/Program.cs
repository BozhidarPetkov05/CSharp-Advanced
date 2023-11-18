namespace P07.__Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            HashSet<string> cars = new HashSet<string>();
            while ((input = Console.ReadLine()) != "END")
            {
                string[] splitted = input.Split(", ");
                string direction = splitted[0];
                string carNumber = splitted[1];
                if (direction == "IN")
                {
                    cars.Add(carNumber);
                }
                else if (direction == "OUT")
                {
                    cars.Remove(carNumber);
                }
            }
            if (cars.Count != 0)
            {
                foreach (string carNumber in cars)
                {
                    Console.WriteLine(carNumber);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            
        }
    }
}
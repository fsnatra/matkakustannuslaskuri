namespace matkakustannuslaskuri
{
    using System;

    public class UserInterface
    {
        private MileageCalculator mileage;

        public UserInterface(MileageCalculator mileage) // Links UI to MileageCalculator class. ? Maybe not sure
        {
            this.mileage = mileage;
        }
    };

    public void Start()
    {
        Console.WriteLine("Mileage Calculator"); // Prints program name (in english)
        Console.WriteLine(""); // Empty line
        while (true)
        {

            // Asks user to input distance and reads value as double. Also calls to check if input is empty to exit.
            Console.WriteLine("Enter distance:");
            double distance = Convert.ToDouble(Console.ReadLine());
            if (IsEmpty(distance))
            {
                break;
            }         

            // Asks user to input conspuption l/100km as double. Also calls to check if value is empty to return to the beginning.
            Console.WriteLine("Enter conspuption (l/100km):");
            double conspuption = Convert.ToDouble(Console.ReadLine());
            if (IsEmpty(conspuption))
            {
                Console.WriteLine("Error, try again.");
                continue;
            }

            // Ask user to input fuel price €/l. Also calls to check if value is empty to return to the beginning.
            Console.WriteLine("Current fuel price? €/l. (Don't input char €)"); // Should add a parser to remove € before continuing, but to keep this simple I only request the input to not include the char €
            double fuelPrice = Convert.ToDouble(Console.ReadLine());

            // Add values to object
            MileageCalculator mileage = new(distance, conspuption, fuelPrice);

            // Calculate the Fuel Used
            mileage.FuelUsed();
        }
    }


    // Method to check if value is empty.
    public bool IsEmpty(var value)
    {
        if (value == "" || value == null)
        {
            return true;
        }

        return false;
    }
}

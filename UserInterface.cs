namespace matkakustannuslaskuri
{
    using System;

    public class UserInterface
    {
        private MileageCalculator mileage;

        public UserInterface(MileageCalculator mileage) // Links UI to MileageCalculator class. ? Maybe not really sure what this does yet lol
        {
            this.mileage = mileage;
        }

        public void Start()
        {
            Console.WriteLine("Mileage Calculator"); // Prints program name (in english)
            Console.WriteLine(""); // Empty line

            string input = ""; // Empty input

            List<MileageCalculator> trips = new List<MileageCalculator>();

            while (true)
            {
                // Asks user to input distance and reads value as double. Also calls to check if input is empty to exit.
                Console.WriteLine("Enter distance:");

                input = Console.ReadLine();
                if (IsEmpty(input))
                {
                    break;
                }

                double distance = Convert.ToDouble(input);

                // Asks user to input conspuption l/100km as double. Also calls to check if value is empty to return to the beginning.
                Console.WriteLine("Enter conspuption (l/100km):");

                input = Console.ReadLine();
                if (IsEmpty(input))
                {
                    Console.WriteLine("Error, try again.");
                    continue;
                }

                double consuption = Convert.ToDouble(input);

                // Ask user to input fuel price €/l. Also calls to check if value is empty to return to the beginning.
                Console.WriteLine("Current fuel price? €/l. (Don't input char €)"); // Should add a parser to remove € before continuing, but to keep this simple I only request the input to not include the char €

                input = Console.ReadLine();
                if (IsEmpty(input))
                {
                    Console.WriteLine("Error, try again.");
                    continue;
                }

                double fuelPrice = Convert.ToDouble(input);

                // Add values to object
                MileageCalculator mileage = new(distance, consuption, fuelPrice);

                // Calculate the rate
                mileage.Calculator();

                // Add results to list
                trips.Add(mileage);

            }

            // Print summary after all the calculations have been done
            PrintSummary(trips);
        }

        // Method to check if value is empty.
        public bool IsEmpty(string value)
        {
            if (value == "")
            {
                return true;
            }

            return false;
        }

        public void PrintSummary(List<MileageCalculator> trips)
        {
            int tripCount = 1;

            Console.WriteLine("Summary:");

            foreach (double totalCost in trip.totalCosts)
            {
                Console.WriteLine(
                    "The total cost of trip " + tripCount + " is " + totalCost + "€."
                );
                tripCount++;
            }
        }
    };
}

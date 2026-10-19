namespace matkakustannuslaskuri
{
    using System;

    public class UserInterface
    {
        public void Start()
        {
            Console.WriteLine("Mileage Calculator"); // Prints program name (in english)

            string input = ""; // Empty input

            List<MileageCalculator> trips = new List<MileageCalculator>();

            while (true)
            {
                // Asks user to input distance and reads value as double. Also calls to check if input is empty to exit.
                Console.WriteLine("---------------"); // Makes it easier to distinguish new object
                Console.WriteLine("Enter distance:");

                input = Console.ReadLine();
                if (IsEmpty(input) || Convert.ToDouble(input) < 0)
                {
                    break;
                }

                double distance = Convert.ToDouble(input);
                Console.WriteLine(""); // Line break

                // Asks user to input consumption l/100km as double. Also calls to check if value is empty to return to the beginning.
                Console.WriteLine("Enter consumption (l/100km):");

                // Reads user input and checks if input empty
                input = Console.ReadLine();
                if (IsEmpty(input) || Convert.ToDouble(input) < 0)
                {
                    Console.WriteLine("Error, try again.");
                    continue;
                }

                // Converts user input to double
                double consumption = Convert.ToDouble(input);
                Console.WriteLine(""); // Line break

                // Ask user to input fuel price €/l. Also calls to check if value is empty to return to the beginning.
                Console.WriteLine("Current fuel price? (€/l):");

                // Reads user input and checks if input empty
                input = Console.ReadLine();
                if (IsEmpty(input) || Convert.ToDouble(input) < 0)
                {
                    Console.WriteLine("Error, try again.");
                    continue;
                }

                // Converts user input to double
                double fuelPrice = Convert.ToDouble(input);

                // Add values to object
                MileageCalculator mileage = new(distance, consumption, fuelPrice);

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

        // Method to print all calculations
        public void PrintSummary(List<MileageCalculator> trips)
        {
            int tripCount = 1; // Starts from one

            if(trips.Count == 0)
            {
                Console.WriteLine("No trips added.");
                return;
            }

            Console.WriteLine("Summary:");

            foreach (MileageCalculator trip in trips) // For each value in list, do ...
            {
                Console.WriteLine(
                    "The total cost of trip " + tripCount + " is " + trip.totalCost + "€." // Print trip number and total cost.
                );
                tripCount++; // Makes the next trip 2, then 3 etc.
            }
        }
    }
}

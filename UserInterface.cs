namespace matkakustannuslaskuri
{
    using System;

    public class UserInterface
    {
        public void Start()
        {
            Console.WriteLine("Mileage Calculator (enter to exit)"); // Prints program name (in english)

            List<MileageCalculator> trips = new List<MileageCalculator>();

            string? input = "";

            while (true)
            {
                // Asks user to input distance and reads value as double. Also calls to check if input is empty to exit.
                Console.WriteLine("---------------"); // Makes it easier to distinguish new object
                Console.Write("Enter distance (km): ");

                input = Console.ReadLine();
                if (!Double.TryParse(input, out double number) || Convert.ToDouble(input) < 0) // https://stackoverflow.com/questions/30654625/c-sharp-how-to-handle-empty-user-input Fixed warnings CS8600 & CS8604 using TryParse
                {
                    if(input != "")
                    {
                        Console.WriteLine("Error, try again");
                        continue;
                    }
                    break;
                }

                double distance = Convert.ToDouble(input);
                Console.WriteLine(""); // Line break

                // Asks user to input consumption l/100km as double. Also calls to check if value is empty to return to the beginning.
                Console.Write("Enter consumption (l/100km): ");

                // Reads user input and checks if input empty
                input = Console.ReadLine();
                if (!Double.TryParse(input, out number) || Convert.ToDouble(input) < 0)
                {
                    Console.WriteLine("Error, try again.");
                    continue;
                }

                // Converts user input to double
                double consumption = Convert.ToDouble(input);
                Console.WriteLine(""); // Line break

                // Ask user to input fuel price €/l. Also calls to check if value is empty to return to the beginning.
                Console.Write("Current fuel price? (€/l): ");

                // Reads user input and checks if input empty
                input = Console.ReadLine();
                if (!Double.TryParse(input, out number) || Convert.ToDouble(input) < 0)
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

                Console.WriteLine(""); // Line break
                Console.WriteLine("Trip saved.");

            }

            // Print summary after all the calculations have been done
            PrintSummary(trips);
        }

        // Method to check if value is empty.
        /* public bool IsEmpty(string input)
        {
            if (input == "")
            {
                return true;
            }

            return false;
        } */

        // Method to print all calculations
        public void PrintSummary(List<MileageCalculator> trips)
        {
            if (trips.Count == 0)
            {
                Console.WriteLine("No trips added.");
                return;
            }

            int tripCount = 1; // Starts from one

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

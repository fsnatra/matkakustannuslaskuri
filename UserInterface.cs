namespace matkakustannuslaskuri
{
    using System;

    public class UserInterface
    {
        private MileageCalculator mileage;

        public UserInterface(MileageCalculator mileage) // Links UI to MileageCalculator class.
        {
            this.mileage = mileage;
        }
    };

    public void Start()
        {
            while (true)
            {
                Console.WriteLine("Mileage Calculator"); // Prints program name (in english)

                // Asks user to input distance and reads value as double. -- NOT IMPLEMENTED YET -- Also calls to check if input is empty to exit.
                Console.WriteLine("Enter distance:");
                double distance = Convert.ToDouble(Console.ReadLine());

                // Asks user to input conspuption l/100km as double. -- NOT IMPLEMENTED YET -- Also calls to check if value is empty to exit.
                Console.WriteLine("Enter conspuption (l/100km):");
                double conspuption = Convert.ToDouble(Console.ReadLine());
            }
        }
}
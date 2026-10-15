namespace matkakustannuslaskuri
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!"); // For environment testing.

            MileageCalculator calculator = new MileageCalculator(); // Creates new objec in MileageCalculator
            UserInterface ui = new UserInterface(calculator);
            ui.Start(); // Calls the UserIn
        }
    }
}

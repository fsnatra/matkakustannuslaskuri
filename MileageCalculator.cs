namespace matkakustannuslaskuri
{
    using System;
    using System.Xml.Serialization;

    public class MileageCalculator
    {
        private double distance;
        private double conspuption;
        private double fuelPrice;
        private double fuelUsed;
        public List<double> totalCosts = new List<double>();

        public MileageCalculator()
        {
            // this.totalCosts = new List<double>(); when mileagecalculator with parameters is called, it doesnt initialize the list so I get error when adding values to it.
        }

        public MileageCalculator(double distance, double conspuption, double fuelPrice) // Takes distance, consuption and fuel price as inputs to object
        {
            this.distance = distance;
            this.conspuption = conspuption;
            this.fuelPrice = fuelPrice;
        }

        public void Calculator()
        {
            // First calculate the fuel used
            FuelUsed();

            // Then the total cost + adds it to the list totalCosts
            TotalCost();
        }

        public void FuelUsed()
        {
            this.fuelUsed = this.distance / 100 * this.conspuption; // Fuel used based on distance and consuption per 100km.
        }

        public void TotalCost()
        {
            this.totalCosts.Add(this.fuelUsed * this.fuelPrice); // Adds the total cost based on fuel used times the fuel price per litre.
        }
    }
}

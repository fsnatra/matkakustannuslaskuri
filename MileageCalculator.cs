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
        public List<double> totalCosts;

        public MileageCalculator()
        {
            this.totalCosts = new List<double>();
        }

        public MileageCalculator(double distance, double conspuption, double fuelPrice) // Takes distance, consuption and fuel price as inputs to object
        {
            this.distance = distance;
            this.conspuption = conspuption;
            this.fuelPrice = fuelPrice;
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

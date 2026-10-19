namespace matkakustannuslaskuri
{
    public class MileageCalculator
    {
        private double distance;
        private double consumption;
        private double fuelPrice;
        private double fuelUsed;
        public double totalCost;

        public MileageCalculator(double distance, double consumption, double fuelPrice) // Takes distance, consumption and fuel price as inputs to object
        {
            this.distance = distance;
            this.consumption = consumption;
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
            this.fuelUsed = this.distance / 100 * this.consumption; // Fuel used based on distance and consumption per 100km.
        }

        public void TotalCost()
        {
            this.totalCost = this.fuelUsed * this.fuelPrice; // Adds the total cost based on fuel used times the fuel price per litre.
            this.totalCost = Math.Round(this.totalCost, 2); // Rounds the total cost to two decimals.
        }
    }
}

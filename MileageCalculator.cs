namespace matkakustannuslaskuri
{
    using System;

    public class MileageCalculator
    {
        private double distance;
        private double conspuption;

        public MileageCalculator(double distance, double conspuption) // Takes distance an consuption as input to object
        {
            this.distance = distance;
            this.conspuption = conspuption;
        }
    }
}

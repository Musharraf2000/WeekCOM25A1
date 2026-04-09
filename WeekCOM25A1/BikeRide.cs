using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekCOM25A1
{
    internal class BikeRide:Ride
    {
        private double discountRate;

        public BikeRide(string rideId, double distance, double ratePerKm, double discountRate) : base(rideId, distance, ratePerKm)
        {
            this.discountRate = discountRate;
        }

        public double DiscountRate { get => discountRate; set => discountRate = value; }

        public override double calculateFare()
        {
            double basicfare = base.calculateFare();
            double discountamount = basicfare * discountRate / 100;
            return basicfare - discountamount;
        }

        public override double calculateFare(double extraDistance)
        {
            double basicfare = base.calculateFare(extraDistance);
            double discountamount = basicfare * discountRate / 100;
            return basicfare - discountamount;
        }
    }
}

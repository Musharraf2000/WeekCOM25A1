using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekCOM25A1
{
    internal class CarRide:Ride
    {
        private double bookingFee;

        public CarRide(string rideId, double distance, double ratePerKm, double bookingFee) : base(rideId, distance, ratePerKm)
        {
            this.bookingFee = bookingFee;
        }

        public override double calculateFare()
        {
            return base.calculateFare() + bookingFee;
        }

        public override double calculateFare(double extraDistance)
        {
            return base.calculateFare(extraDistance) + bookingFee;
        }
    }
}

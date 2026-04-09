using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekCOM25A1
{
    internal class Ride
    {
        private string rideId;
        private double distance;
        private double ratePerKm;

        public Ride(string rideId, double distance, double ratePerKm)
        {
            this.rideId = rideId;
            this.distance = distance;
            this.ratePerKm = ratePerKm;
        }

        public string RideId { get => rideId; set => rideId = value; }
        public double Distance { get => distance; set => distance = value; }
        public double RatePerKm { get => ratePerKm; set => ratePerKm = value; }

        public virtual double calculateFare()
        {
            return distance * ratePerKm;
        }

        public virtual double calculateFare(double extraDistance)
        {
            return (distance+extraDistance) * ratePerKm;
        }



    }
}

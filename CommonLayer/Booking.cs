using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer
{
    public class Booking
    {
        private float cost;
        private string flightId;
        private List<Passenger> passengers;
        private int referenceId;
        private int seats;
        private string status;
        private DateTime travelon;
        private string userId;
        public float Cost
        {
            get
            {
                return cost;
            }
            set
            {

                cost = value;
            }
        }
        public string FlightId
        {
            get
            {
                return flightId;
            }
            set
            {

                flightId = value;
            }
        }
        public List<Passenger> Passengers
        {
            get
            {
                return passengers;
            }
            set
            {

                passengers = value;
            }
        }
        public int ReferenceId
        {
            get
            {
                return referenceId;
            }
            set
            {

                referenceId = value;
            }
        }
        public int Seats
        {
            get
            {
                return seats;
            }
            set
            {

                seats = value;
            }
        }
        public string Status
        {
            get
            {
                return status;
            }
            set
            {

                status = value;
            }
        }
        public DateTime Travelon
        {
            get
            {
                return travelon;
            }
            set
            {

                travelon = value;
            }
        }
        public string UserId
        {
            get
            {
                return userId;
            }
            set
            {

                userId = value;
            }
        }
        public Booking(int referenceId, string userId, DateTime travelon, string flightId, string status, int seats, float cost)
        {
            ReferenceId = referenceId;
            UserId = userId;
            Travelon = travelon;
            FlightId = flightId;
            Status = status;
            Seats = seats;
            Cost = cost;
 
        }
        public Booking(string userId, DateTime travelon, string flightId, string status, int seats, float cost)
        {
            ReferenceId = -1;
            Status = "B";
            UserId = userId;
            Travelon = travelon;
            FlightId = flightId;
            Seats = seats;
            Cost = cost;
 
        }
        public void AddPassenger(string name, int age)
        {
            
            Passengers.Add(new Passenger(name,age));
            seats++;
            cost = cost++;
 
        }
        public void Cancel()
        {
            status = "C";
            seats = 0;
            cost = 0;
 
        }
        public bool Cancel(int referenceId, int ticket)
        {
            status = "P";
            seats--;
            cost--;
            return false;
        }


    }
}

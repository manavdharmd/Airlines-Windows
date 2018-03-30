﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer
{
    public class FlightSchedule
    {
        private string arrival;
        private float cost;
        private string departure;
        private DateTime flightdate;
        private string flightId;
        private int seatsAvaliable;
        public string Arrival
        {
            get
            {
                return arrival;
            }
            set
            {

                arrival = value;
            }
        }
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
        public string Departure
        {
            get
            {
                return departure;
            }
            set
            {

                departure = value;
            }
        }
        public DateTime Flightdate
        {
            get
            {
                return flightdate;
            }
            set
            {

                flightdate = value;
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
        public int SeatsAvaliable
        {
            get
            {
                return seatsAvaliable;
            }
            set
            {

                seatsAvaliable = value;
            }
        }
        public FlightSchedule(string flightId, DateTime flightdate, int seatsAvaliable, float cost, string arrival, string departure)
        {
            flightId = this.flightId;
            flightdate = this.flightdate;
            seatsAvaliable = this.seatsAvaliable;
            cost = this.cost;
            arrival = this.arrival;
            departure = this.departure;

        }
        public FlightSchedule(string flightId, string arrival, string departure)
        {

        }
        public FlightSchedule(string flightId, int seatsAvaliable, float cost)
        {

        }
        
        
    }
}

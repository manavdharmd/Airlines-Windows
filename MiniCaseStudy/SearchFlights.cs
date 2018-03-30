using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceLayer;
using CommonLayer;
namespace MiniCaseStudy
{
    public partial class SearchFlights : Form
    {
        public SearchFlights()
        {
            InitializeComponent();
        }
        AirlineService ob = new AirlineService();

      
        private void btn_search_Click(object sender, EventArgs e)
        {
            string origin = comboBox1.SelectedItem.ToString();
            string des = comboBox2.SelectedItem.ToString();
           
             List<FlightSchedule> l_ob =ob.GetFlightsInRoute(origin,des);
            foreach (FlightSchedule item in l_ob)
            {
                checkedListBox1.Items.Add("Flight Id: " + item.FlightId + " Flight Date: " + item.Flightdate + " Seats Available:" + item.SeatsAvaliable + " Arrival: " + item.Arrival + " Departure: " + item.Departure + " Cost: " + item.Cost);
                
            }

        }

        private void btn_searchid_Click(object sender, EventArgs e)
        {
             List<FlightSchedule> l_ob= ob.GetFlightSchedule(txt_id.Text, Convert.ToDateTime(txt_date.Text));
             foreach (FlightSchedule item in l_ob)
             {
                 checkedListBox1.Items.Add("Flight Id: " + item.FlightId + " Flight Date: " + item.Flightdate + " Seats Available:" + item.SeatsAvaliable + " Arrival: " + item.Arrival + " Departure: " + item.Departure + " Cost: " + item.Cost);

             }

            
        }

        private void SearchFlights_Load(object sender, EventArgs e)
        {
            List<City> l_city=ob.GetAllCities();
            foreach (City item in l_city)
	        {
                comboBox1.Items.Add("Name: "+item.Name+ "Airport: "+item.AirPort);
                comboBox2.Items.Add("Name: " + item.Name + "Airport: " + item.AirPort);
		 
	        }
           


        }
    }
}

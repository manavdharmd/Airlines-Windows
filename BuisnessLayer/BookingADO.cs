using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer;
using System.Data.SqlClient;
using System.Data;
using DataLayer;
using BuisnessLayer.UserExceptions;

namespace BuisnessLayer
{
    public class BookingADO
    {
        DBConnection d_ob = new DBConnection();
        public List<Booking> GetALLBookings(string userId)
        {
            SqlConnection con = d_ob.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from AR_Bookings where User_Id=@uid and Status not like 'C' ";
            cmd.Parameters.AddWithValue("@uid", userId);
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            List<Booking> l_book = new List<Booking>();
            while (dr.Read())
            {
                l_book.Add(new Booking(Convert.ToInt32(dr[0]),dr[1].ToString(),Convert.ToDateTime(dr[6]),dr[2].ToString(),dr[3].ToString(),Convert.ToInt32(dr[4]),float.Parse(dr[5].ToString())));
            }
            d_ob.CloseConnection();
            return l_book;

 
        }
        public List<Booking> GetBookingsForCancel(string userId)
        {
            SqlConnection con = d_ob.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from AR_Bookings where User_Id=@uid";
            cmd.Parameters.AddWithValue("@uid", userId);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Booking> l_book = new List<Booking>();
            while (dr.Read())
            {
                l_book.Add(new Booking(Convert.ToInt32(dr[0]), dr[1].ToString(), Convert.ToDateTime(dr[6]), dr[2].ToString(), dr[3].ToString(), Convert.ToInt32(dr[4]), float.Parse(dr[5].ToString())));
            }
            d_ob.CloseConnection();
            return l_book;


        }
        public Booking GetBookingPassengers(int bookingref)
        {
            SqlConnection con = d_ob.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from AR_Bookings where Reference_Id=@refid";
            cmd.Parameters.AddWithValue("@refid", bookingref);
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            Booking book_ob=new Booking(Convert.ToInt32(dr[0]), dr[1].ToString(), Convert.ToDateTime(dr[6]), dr[2].ToString(), dr[3].ToString(), Convert.ToInt32(dr[4]), float.Parse(dr[5].ToString()));
            d_ob.CloseConnection();
            return book_ob;

        }
        public int SaveBooking(Booking booking)
        {
            try
            {
                if (booking != null)
                {

                    if (booking.ReferenceId == -1)
                    {
                        return CreateBooking(booking);

                    }
                    else
                    {
                        return UpdateBooking(booking);

                    }
                }
                else
                {
                    throw new CancelException("Database not accessable");
                }
            }
            catch(CancelException)
            {
                return 0;
            }
 
        }
        private int CreateBooking(Booking booking)
        {
            SqlConnection con = d_ob.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "pr_Booking_Save";
            cmd.Parameters.AddWithValue("@userId",booking.UserId);
            cmd.Parameters.AddWithValue("@flightId",booking.FlightId);
            cmd.Parameters.AddWithValue("@flightDate",booking.Travelon);
            cmd.Parameters.AddWithValue("@seats",booking.Seats);
            cmd.Parameters.AddWithValue("@cost",booking.Cost);
        
            
            cmd.Connection = con;
            booking.ReferenceId = Convert.ToInt32(cmd.ExecuteScalar());

            d_ob.CloseConnection();
            try
            {
                if (booking.ReferenceId < 0)
                {
                    List<Passenger> p = booking.Passengers;
                    foreach (Passenger item in p)
                    {
                        SqlConnection con1 = d_ob.GetConnection();
                        SqlCommand cmd1 = new SqlCommand();
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.CommandText = "pr_Passenger_Save";
                        cmd1.Parameters.AddWithValue("@referenceID", booking.ReferenceId);
                        cmd1.Parameters.AddWithValue("@name", item.Name);
                        cmd1.Parameters.AddWithValue("@age", item.Age);
                        cmd1.Connection = con1;
                        int ticketno = Convert.ToInt32(cmd1.ExecuteScalar());
                        d_ob.CloseConnection();
                    }
                }
                else
                    throw new BookingException("Database not accessable");
            }
            catch (BookingException )
            {
 
            }
            return booking.ReferenceId;
            

        }
        private int UpdateBooking(Booking booking)
        {
            SqlConnection con = d_ob.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update AR_Bookings set Status=@status, TotalCost=@cost , BookSeats=@seats where Reference_Id=@refId";
            cmd.Parameters.AddWithValue("@status", booking.Status);
            cmd.Parameters.AddWithValue("@seats",booking.Seats );
            cmd.Parameters.AddWithValue("@cost", booking.Cost);
            cmd.Parameters.AddWithValue("@refId", booking.ReferenceId);
            cmd.Connection = con;
            int res=cmd.ExecuteNonQuery();
            d_ob.CloseConnection();
            return res;
            
 
        }

    }
}

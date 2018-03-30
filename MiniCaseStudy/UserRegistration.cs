using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonLayer;
using ServiceLayer;



namespace MiniCaseStudy
{
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            AirlineService ob = new AirlineService();
            User u = new User(txt_id.Text, txt_name.Text, txt_paswd.Text, Convert.ToInt32(txt_age.Text), txt_ccno.Text, txt_cctype.Text,Convert.ToInt32(txt_ccmonth.Text),Convert.ToInt32(txt_ccyear.Text));
            int cn=ob.RegisterUser(u);
            if (cn == 1)
            {
                MessageBox.Show("Registered Succesfully");
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong.Try again");
            }


        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

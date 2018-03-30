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

namespace MiniCaseStudy
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            AirlineService ob = new AirlineService();
            bool res=ob.ValidateUser(txt_id.Text, txt_pass.Text);
            if (res == true)
            {
                MessageBox.Show("Logged in Succesfully");
                AirLineReservationMDI aob = new AirLineReservationMDI { id=txt_id.Text};
                aob.Show();
                this.Close();
            }
            else 
            {
                MessageBox.Show("Invalid User");
            }
        }
    }
}

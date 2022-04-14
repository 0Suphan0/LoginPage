using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulbpharaProject
{
    public partial class Form2 : Form
    {
        public static Customer myCustomer;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Customer customer)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblName.Text = "Hoşgeldiniz " + myCustomer.Name + " " + myCustomer.Surname;
        }

        
    }
}

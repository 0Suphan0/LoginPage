using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BulbpharaProject.Properties;

namespace BulbpharaProject
{
    public partial class Form1 : Form
    {
        private List<Customer> allCustomers;
        private CustomerDal customerDal = new CustomerDal();
        Form2 form2 = new Form2();


        public Form1()
        {
            InitializeComponent();
        }

        private void syToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (syToggleButton1.Checked)
            {
                this.BackgroundImage = Properties.Resources._1775631;
                bulbharaLabel.ForeColor = Color.FromArgb(1, 255, 255, 128);
                lblSignUp.ForeColor = Color.FromArgb(1, 255, 255, 128);
                lblLogin.ForeColor = Color.FromArgb(1, 255, 255, 128);

            }
            else
            {
                this.BackgroundImage = Properties.Resources.ezgif_5_365939c69b;
                bulbharaLabel.ForeColor = Color.White;
                lblSignUp.ForeColor = Color.White;
                lblLogin.ForeColor = Color.White;
            }
        }

        private void syComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var result = CheckCustomer();
            //sonuca göre işlem
            if (result)
            {
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");

            }
                
        }

        private bool CheckCustomer()
        {
            //Databasedan listeyi çekmek
            var allCustomers = customerDal.GetList();

            //listeyi dön ve kıyasla..
            foreach (var item in allCustomers)
            {
                if (item.Username.Equals(tbxUserName.Texts) && item.Password.Equals(tbxPass.Texts))
                {
                    Form2.myCustomer=item;
                    return true;
                }
            }

            return false;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (tbxSignName.Texts.Length == 0 || tbxSignSurname.Texts.Length == 0 || tbxSignPass.Texts.Length == 0 ||
                tbxSignUserName.Texts.Length == 0 || comboCity.Texts.Equals("İl Seçiniz"))
            {
                MessageBox.Show("Tüm Alanları Doldurun");
            }
            else
            {
                customerDal.Add(new Customer() { Name = tbxSignName.Texts, Surname = tbxSignSurname.Texts, City = comboCity.Texts, Username = tbxSignUserName.Texts, Password = tbxSignPass.Texts });
                MessageBox.Show("Başarıyla Kaydedildi.");
            }
            
        }

        
    }
}

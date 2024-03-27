using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encapsulation_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car nCar = new Car();

            nCar.Year = -2023;
            nCar.Brand = "Porsche";
            nCar.plate = "11 ABS 043";
            nCar.peak = 2023;
            nCar.owner = "Alperen";

            MessageBox.Show($"Latest Car the Year: {nCar.Year}\nBrand: {nCar.Brand}\nPlate: {nCar.plate}\nPeak: {nCar.peak}\nOwner: {nCar.owner}");
        }
    }
}

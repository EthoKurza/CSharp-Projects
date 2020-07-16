using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTHeyzzenFlores
{
    public partial class Form2 : Form
    {
        public static Car CarInfo { get; set; }
        List<Car> carList;
        public Form2()
        {
            InitializeComponent();
            CarInfo = new Car();
            carList = new List<Car>();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //set combobox 
            cmbCars.Items.Insert(0, "Select a car");
            cmbCars.SelectedIndex = 0;
            
            //initialize list
            carList.Add(new Car("Honda Civic", 23000));
            carList.Add(new Car("Toyota Corolla", 20000));
            carList.Add(new Car("Ford Fusion", 22000));
            carList.Add(new Car("Hyundai Elantra", 17000));
            carList.Add(new Car("Nissan Altima", 26000));

            //display list into combo box
            foreach(Car c in carList)
            {
                cmbCars.Items.Add(c.Name);
            }


        }//end of form 2 load

        private void cmbCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            // enable/disable based on item selected
            if(cmbCars.SelectedIndex == 0)
            {
                btnOK.Enabled = false;
            }
            else
            {
                btnOK.Enabled = true;   
            }
        }//end of cmbCars_SelectedIndexChanged

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }//end of btnCancel

        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveCar(carList, cmbCars.SelectedIndex);
            Close();   
        }//end of btnOK

        //methods
        public void SaveCar(List<Car> cList, int sIndex)
        {
            CarInfo = new Car(cList[sIndex - 1].Name, cList[sIndex - 1].Price);
        }//end of SaveCar
    }
}

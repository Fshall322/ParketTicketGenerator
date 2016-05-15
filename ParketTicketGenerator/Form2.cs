using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParketTicketGenerator
{
    public partial class Form2 : Form
    {

        public Form2(Car yourCar,Person user,ParkingMeter yourTime,Cop cops, int timeOver, int timePurchased, DateTime answer, double totalFine, int movedTime, double costOfFine) // start form2 constructor
        {
            InitializeComponent();

            
            makeText.Text = yourCar.Make; // code for output to the proper text boxes
            modelText.Text = yourCar.Model;
            colorText.Text = yourCar.Color;
            yearText.Text = yourCar.Year.ToString();
            plateNoText.Text = yourCar.PlateNumber;
            string names = user.UserFName + " " + user.UserLName; // concantenates userFirstname and last name together
            nameText.Text = names.ToString();
            copNameText.Text = cops.Name;
            copBadgeText.Text = cops.BadgeNumber;
            timeOverText.Text = timeOver.ToString();
            timePurchText.Text = timePurchased.ToString();
            totalFineText.Text = costOfFine.ToString("C");
            System.DateTime localDate = System.DateTime.Now;
            dateTimeText.Text = answer.ToString();
        }
       
    }
}

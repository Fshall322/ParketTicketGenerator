using System;
using System.Windows.Forms;

namespace ParketTicketGenerator
{
    public partial class MainForm : Form// star MainForm
    {
        Car yourCar = new Car(); // new car instance
        DateTime answer; // DateTime Variable called answer
        Person user = new Person(); //Paerson instance called user
        Cop cops = new Cop(); // cop instance called cops
        ParkingMeter yourTime = new ParkingMeter(); // parkingmeter instance called yourTime

        DateTime localDate = DateTime.Now; // local time
        Random timeElapse = new Random(); // random number to determine the amount of time elapsed
        int movedTime = 0; //variable for the amount of time moved
        int timeOver = 0; // variable for the time user went over
        int timePurchased = 0; // variable for the amount of time user purchased
        double totalFine = 0; // variable for the amount of total time.
        double timeCost = 0; // variable for the amount of timeCost.
        double costOfFine = 0; // variable for the amount of total cost of all fines

        public MainForm()
        {
            InitializeComponent();
        }

        private void transactionButton_Click(object sender, EventArgs e) // transaction button event
        {


            yourCar.Make = makeText.Text; // make object except text value to the proper variable with in the class
            yourCar.Model = modelText.Text; // make object except text value to the proper variable with in the class
            yourCar.Color = colorText.Text; // make object except text value to the proper variable with in the class
            yourCar.Year = yearText.Text; // make object except text value to the proper variable with in the class
            yourCar.PlateNumber = plateText.Text; // make object except text value to the proper variable with in the class
            user.UserFName = firstNameText.Text; // make object except text value to the proper variable with in the class
            user.UserLName = lastNameText.Text; // make object except text value to the proper variable with in the class
            string names = user.UserFName + " " + user.UserLName; // make object except text value to the proper variable with in the class
            yourTime.PurchTime = int.Parse(purchTimeText.Text.ToString()); // make object except text value to the proper variable with in the class
            timeCost = yourTime.PurchTime * .50; // make object except text value to the proper variable with in the class
            string s = timeCost.ToString("C"); // make object except text value to the proper variable with in the class
            timePurchased = yourTime.PurchTime; // make object except text value to the proper variable with in the class


            MessageBox.Show("For vehicle plate number: " + yourCar.PlateNumber + "\n A " + yourCar.Color + " " + yourCar.Year + " " + yourCar.Make + " " + yourCar.Model); // a confirmation of the time purchsed for the meter
            MessageBox.Show(names + " Your purchase is complete\n" + "The amount of hours purchased is : " + yourTime.PurchTime + "\nYour total amount for your time is : " + s);

            timeOver = timePurchased - movedTime; // math to figure out the time that the user went over
            totalFine = timeOver * 10.00; // determines the fines for all hours over
            costOfFine = totalFine + 25.00; // adds in the initial 25.00 fine
        }

        private void elapseTimeButton_Click(object sender, EventArgs e)
        {
            movedTime = timeElapse.Next(1, 11); // makes the variable equal the random number generated
            switch (movedTime) // switch case to add the appropriate hours to the local time.
            {
                case 1:
                    answer = localDate.AddHours(1.0);
                    dateTimeText.Text = answer.ToString();
                    break;
                case 2:
                    answer = localDate.AddHours(2.0);
                    dateTimeText.Text = answer.ToString();
                    break;
                case 3:
                    answer = localDate.AddHours(3.0);
                    dateTimeText.Text = answer.ToString();
                    break;
                case 4:
                    answer = localDate.AddHours(4.0);
                    dateTimeText.Text = answer.ToString();
                    break;
                case 5:
                    answer = localDate.AddHours(5.0);
                    dateTimeText.Text = answer.ToString();
                    break;
                case 6:
                    answer = localDate.AddHours(6.0);
                    dateTimeText.Text = answer.ToString();
                    break;
                case 7:
                    answer = localDate.AddHours(7.0);
                    dateTimeText.Text = answer.ToString();
                    break;
                case 8:
                    answer = localDate.AddHours(8.0);
                    dateTimeText.Text = answer.ToString();
                    break;
                case 9:
                    answer = localDate.AddHours(9.0);
                    dateTimeText.Text = answer.ToString();
                    break;
                case 10:
                    answer = localDate.AddHours(10.0);
                    dateTimeText.Text = answer.ToString();
                    break;
            }
            copButton.Show(); // shows and hides certain things when the transaction button is clicked
            copLabel.Show();
            makeText.Hide();
            modelText.Hide();
            colorText.Hide();
            yearText.Hide();
            plateText.Hide();
            makeLabel.Hide();
            carModelLabel.Hide();
            carColorLabel.Hide();
            carInfoLabel.Hide();
            yearLabel.Hide();
            plateNumLabel.Hide();
            transactionButton.Hide();
            personalInfoLabel.Hide();
            fnameLabel.Hide();
            lnameLabel.Hide();
            firstNameText.Hide();
            lastNameText.Hide();
            purchaseInfoLabel.Hide();
            timePurchLabel.Hide();
            purchTimeText.Hide();
            elapseTimeButton.Hide();
        }

        private void Form1_Load(object sender, EventArgs e) // creates local date and hides things on form load
        {
            DateTime localDate = DateTime.Now;
            dateTimeText.Text = localDate.ToString();
            copButton.Hide();
            copLabel.Hide();
        }

        private void copButton_Click(object sender, EventArgs e) // checks to see if you went over your time purchased and issues a ticket if you had.
        {
            if (yourTime.PurchTime >= movedTime)
            {
                MessageBox.Show("Your Good");
            }
            else
            {
                MessageBox.Show("Your Screwed");
                Form2 form2 = new Form2(yourCar, user, yourTime, cops, timeOver, timePurchased, answer, totalFine, movedTime, costOfFine);// creates an instance of form2 , passes arguments that gets repeated on the next form so the classes can be accessed
                form2.Show();// shows form 2
                MainForm form1 = new MainForm();
                form1.Close(); // closes form2
            }
        }
    }
}

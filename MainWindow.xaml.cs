using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace DateAndTime
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public DateTime datee = DateTime.Now;
        public MainWindow()
        {

            

            InitializeComponent();

            TextBox1.Text = DateTime.Now.ToString("h:mm tt"); //result 11:11:45 PM

          //  System.DateTime date = new System.DateTime(DateTime.Now.ToString("h:mm tt");
        }
        
     
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            if (TextBox1.SelectionStart <= 1)
            {
                int index = TextBox1.CaretIndex;
                String date = TextBox1.Text;
                DateTime stringDate = DateTime.Parse(date);
                DateTime newDate = stringDate.AddHours(1);
                String textDate = Convert.ToString(newDate);
                textDate = newDate.ToString("h:mm tt");
                TextBox1.Text = textDate.ToString();
                TextBox1.SelectionStart = index;
            }
            else if (TextBox1.SelectionStart >= 2 && TextBox1.SelectionStart <= 4)
            {
                int index1 = TextBox1.CaretIndex;
                String minuteDate = TextBox1.Text;
                DateTime stringDate = DateTime.Parse(minuteDate);
                DateTime newMinuteDate = stringDate.AddMinutes(1);
                String textDate = Convert.ToString(newMinuteDate);
                textDate = newMinuteDate.ToString("h:mm tt");
                TextBox1.Text = textDate.ToString();
                TextBox1.SelectionStart = index1;



            }
            else if (TextBox1.SelectionStart >= 5 && TextBox1.SelectionStart <= 7) {

                int index2 = TextBox1.CaretIndex;
                String amPmDate = TextBox1.Text;
                DateTime stringDate = DateTime.Parse(amPmDate);
                DateTime newAmPmDate = stringDate.AddHours(12);
                String textDate = Convert.ToString(newAmPmDate);
                textDate = newAmPmDate.ToString("h:mm tt");
                TextBox1.Text = textDate.ToString();
                TextBox1.SelectionStart = index2;
            }
            
          

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            
            if (TextBox1.SelectionStart <= 1)
            {
                int index = TextBox1.CaretIndex;
              
                String date = TextBox1.Text;
                DateTime stringDate = DateTime.Parse(date);
                DateTime newDate = stringDate.AddHours(-1);
                String textDate = Convert.ToString(newDate);
                textDate = newDate.ToString("h:mm tt");
                TextBox1.Text = textDate.ToString();
                TextBox1.SelectionStart = TextBox1.CaretIndex;

            }
            else if (TextBox1.SelectionStart >= 2 && TextBox1.SelectionStart <= 4)
            {
                int index1 = TextBox1.CaretIndex;
               
                String minuteDate = TextBox1.Text;
                DateTime stringDate = DateTime.Parse(minuteDate);
                DateTime newMinuteDate = stringDate.AddMinutes(-1);
                String textDate = Convert.ToString(newMinuteDate);
                textDate = newMinuteDate.ToString("h:mm tt");
                TextBox1.Text = textDate.ToString();
                TextBox1.SelectionStart = index1;
                


            }
            else if (TextBox1.SelectionStart >= 5 && TextBox1.SelectionStart <= 7)
            {
                int index2 = TextBox1.CaretIndex;
                
                String amPmDate = TextBox1.Text;
                DateTime stringDate = DateTime.Parse(amPmDate);
                DateTime newAmPmDate = stringDate.AddHours(12);
                String textDate = Convert.ToString(newAmPmDate);
                textDate = newAmPmDate.ToString("h:mm tt");
                TextBox1.Text = textDate.ToString();
                TextBox1.SelectionStart = index2;

            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Select button event handler
            String textTime = TextBox1.Text;

            //made to handle if user doesnt click a calendar date
            if (calendar1.SelectedDate == DateTime.MinValue)
            {
                MessageBox.Show("You did not select a date, however, if you had it would have been scheduled at " + textTime);

            }
          
           
            String appointment = calendar1.SelectedDate.ToString();
           DateTime appoint = DateTime.Parse(appointment);
            String day = appoint.DayOfWeek.ToString();
            String dateForm = appoint.ToString("MM/dd/yyyy");

            DateTime startDate = new DateTime();
            startDate = DateTime.Now;

            double totalDays = (appoint - startDate).TotalDays;

            totalDays = Math.Truncate(totalDays * 1000) / 1000;
            MessageBox.Show("Your appointment is on " + day + ", " + dateForm + " at " + textTime + ", it is " + totalDays + " days from today");






        }

        private void calendar1_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            if (calendar1.SelectedDate == DateTime.MinValue)
            {
                MessageBox.Show("You did not select a date, however, if you had it would have been scheduled at ");

            }

        }


    }
}

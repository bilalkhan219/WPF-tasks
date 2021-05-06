using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace task02
{
    public class viewmodel
    {
        public delegatecommand cmd { get; set; }
        public delegatecommand cmd2 { get; set; }
        public viewmodel()
        {
            cmd = new delegatecommand(submitbutton, canexecute);
            cmd2 = new delegatecommand(cancelbutton, cancelexecute);
        }
        public bool canexecute(object m)
        {
            var data = m as object[];
            var name = data[0] as string;
            var gender = data[1] as string;
            var graduated = data[2] as System.Windows.Controls.RadioButton;
            var graduated2 = data[3] as System.Windows.Controls.RadioButton;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(gender) || (graduated.IsChecked == graduated2.IsChecked))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void submitbutton(object m)
        {
            var data = m as object[];
            var name = data[0] as string;
            var gender = data[1] as string;
            var graduated = data[2] as System.Windows.Controls.RadioButton;
            var graduated2 = data[3] as System.Windows.Controls.RadioButton;
            string s = string.Empty;
            if (graduated.IsChecked == true) {
                s = $"Name: {data[0]}" +
                    $", Gender: {data[1]}" +
                    $", Graduation Status: Graduated";
                }
            else
            {
                s = $"Name: {data[0]}" +
                    $", Gender: {data[1]}" +
                    $", Graduation Status: NotGraduated";

            }
            Window1 win = new Window1();
            win.output.Text = s;
            win.Show();

        }
        public bool cancelexecute(object m)
        {
            return true;
        }
        public void cancelbutton(object m)
        {
            var data = m as object[];
            var wind = data[0] as MainWindow;
            wind.Close();
        }
    }
}

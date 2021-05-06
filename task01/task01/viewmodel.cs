using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace task01
{
    public class viewmodel
    {
        public DelegateCommand cmd { get; set; }
        public DelegateCommand cmd2 { get; set; }

        public viewmodel()
        {
            cmd = new DelegateCommand(submitbutton, canExecute);
            cmd2 = new DelegateCommand(cancelbutton, cancelexecute);
        }
        public bool canExecute(object values)
        {
            var data = values as object[];
            var mainwin = data[0] as MainWindow;
            var id = data[1] as string;
            var oldp = data[2] as System.Windows.Controls.PasswordBox;
            var newp = data[3] as System.Windows.Controls.PasswordBox;
            var verifyp = data[4] as System.Windows.Controls.PasswordBox;
            if (newp.Password == verifyp.Password)
            {
                mainwin.not.Visibility = Visibility.Hidden;
            }
            else
            {
                mainwin.not.Visibility = Visibility.Visible;

            }
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(oldp.Password) || string.IsNullOrEmpty(newp.Password) || string.IsNullOrEmpty(verifyp.Password))
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

            MessageBox.Show("User added successfully");

        }
        public void cancelbutton(object m)
        {
            var data = m as object[];
            var mainwin = data[0] as MainWindow;
            mainwin.Close();
        }
        public bool cancelexecute(object m)
        {
            return true;
        }
    }
}

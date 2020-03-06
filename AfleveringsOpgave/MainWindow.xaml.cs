using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;


namespace AfleveringsOpgave
{
    
    public partial class MainWindow : Window
    {
        List<User> users = new List<User>();

        public MainWindow()
        {
            InitializeComponent();
        }

        public void OpenFileDialog(object sender, RoutedEventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = ".txt";
            dlg.Filter = "txt Files (*.txt)|*.txt";

            if (dlg.ShowDialog() == true)
            {
                string filename = dlg.FileName;
                
                using(StreamReader SR = new StreamReader(filename))
                {
                    string line;
                    while ((line = SR.ReadLine()) != null)
                    {
                        string[] data = line.Split(';');
                        users.Add(new User(int.Parse(data[0]), data[1], int.Parse(data[2]), int.Parse(data[3])));
                    }
                }

                PersonBox.ItemsSource = users;
                bigGrid.DataContext = users;

                lines.Text = "Users: " + users.Count().ToString() + ",";
                time.Text = "Time loaded: " + DateTime.Now.ToString("HH:mm:ss");
            }
        }
    }
}

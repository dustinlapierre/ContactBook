using DesktopContactsApp.Classes;
using SQLite;
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
using System.Windows.Shapes;

namespace DesktopContactsApp
{
    /// <summary>
    /// Interaction logic for NewContactWindow.xaml
    /// </summary>
    public partial class NewContactWindow : Window
    {
        public NewContactWindow()
        {
            InitializeComponent();

            Owner = Application.Current.MainWindow;
            WindowStartupLocation = WindowStartupLocation.CenterOwner;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Save Contact to DB
            Contact contact = new Contact()
            {
                Name = nameTextBox.Text,
                Email = emailTextBox.Text,
                Phone = phoneTextBox.Text
            };

            //will automatically close the connection at the end
            //this can be done with anything that implements IDisposable
            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
                //will do nothing if table already exists, so it is safe to call each time
                connection.CreateTable<Contact>();
                connection.Insert(contact);
            }

            //Close Window
            Close();
        }
    }
}

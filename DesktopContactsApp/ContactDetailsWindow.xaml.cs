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
    /// Interaction logic for ContactDetailsWindow.xaml
    /// </summary>
    public partial class ContactDetailsWindow : Window
    {
        Contact contact;
        public ContactDetailsWindow(Contact contact)
        {
            InitializeComponent();

            this.contact = contact;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            //will automatically close the connection at the end
            //this can be done with anything that implements IDisposable
            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
                //will do nothing if table already exists, so it is safe to call each time
                connection.CreateTable<Contact>();
                connection.Delete(contact);
            }

            //Close Window
            Close();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

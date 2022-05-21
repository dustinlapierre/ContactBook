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

            Owner = Application.Current.MainWindow;
            WindowStartupLocation = WindowStartupLocation.CenterOwner;

            this.contact = contact;
            nameTextBox.Text = contact.Name;
            emailTextBox.Text = contact.Email;
            phoneTextBox.Text = contact.Phone;
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
            contact.Name = nameTextBox.Text;
            contact.Email = emailTextBox.Text;
            contact.Phone = phoneTextBox.Text;

            //will automatically close the connection at the end
            //this can be done with anything that implements IDisposable
            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
                //will do nothing if table already exists, so it is safe to call each time
                connection.CreateTable<Contact>();
                connection.Update(contact);
            }

            //Close Window
            Close();
        }
    }
}

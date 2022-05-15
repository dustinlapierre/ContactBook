using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SQLite;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DesktopContactsApp.Classes;

namespace DesktopContactsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Contact> contacts;
        public MainWindow()
        {
            InitializeComponent();
            contacts = new List<Contact>();
            ReadDatabase();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewContactWindow newContactWindow = new NewContactWindow();
            //this is blocking code and will not continue until the window is closed
            newContactWindow.ShowDialog();

            ReadDatabase();
        }

        void ReadDatabase()
        {
            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
                //make sure table exists
                connection.CreateTable<Contact>();

                //get list of contacts
                //order by name alphabetical
                contacts = connection.Table<Contact>().OrderBy(c=>c.Name).ToList();
            };

            if(contacts != null)
            {
                contactsListView.ItemsSource = contacts;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox searchTextBox = sender as TextBox;

            var filteredList = contacts.Where(x => x.Name.ToLower().Contains(searchTextBox.Text.ToLower())).ToList();

            /*
           
            Alternative full linq syntax

            var filteredList2 = (from c in contacts
                                where c.Name.ToLower().Contains(searchTextBox.Text.ToLower())
                                orderby c.Name
                                select c).ToList();
            */

            contactsListView.ItemsSource = filteredList;
        }

        private void contactsListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //guard clause
            if (contactsListView.SelectedItems.Count != 1) return;

            Contact selectedContact = (Contact)contactsListView.SelectedItem;
            if (selectedContact != null)
            {
                ContactDetailsWindow contactDetailsWindow = new ContactDetailsWindow(selectedContact);
                contactDetailsWindow.ShowDialog();
                ReadDatabase();
            }
        }
    }
}

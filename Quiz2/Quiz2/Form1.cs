using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        FileIO fileIO = new FileIO();

        private void register_Click(object sender, EventArgs e) {

            //Storing values from text boxes 
            String firstName = fname.Text;
            String lastName = lname.Text;
            String telNumber = tel.Text;
            String empty = String.Empty;

            // Check if fields are not empty
            if((firstName != empty) && 
                (lastName != empty) && 
                (telNumber != empty)) {

                //Create User Object
                User user = new User(firstName, lastName, telNumber);

                //String to insert into file
                String userInfo = "First Name: " + firstName + " Last Name: " + lastName + " Telephone: " + telNumber;

                //Path of file
                String path = @"C:\Users\1332549\Desktop\Users\users.txt";

                // Method call to create file users
                fileIO.CreateFile(userInfo, path);
                MessageBox.Show("User has been created");
            }

            //Display message if any field is empty
            else {
                MessageBox.Show("Field is empty");
            }
        }

        private void clearform_Click(object sender, EventArgs e) {
            fname.Clear();
            lname.Clear();
            tel.Clear();

        }

        private void countusers_Click(object sender, EventArgs e) {
           
            String path = @"C:\Users\1332549\Desktop\Users\users.txt";
            int numberOfUsers = fileIO.NumberOfUsers(path);

            MessageBox.Show("Number of users: " + numberOfUsers);
        }

        private void deleteusers_Click(object sender, EventArgs e) {
            String path = @"C:\Users\1332549\Desktop\Users\users.txt";
            fileIO.DeleteFile(path);
            MessageBox.Show("File has been deleted!");
        }
    }
}

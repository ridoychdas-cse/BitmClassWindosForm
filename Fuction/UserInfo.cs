using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuction
{
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
        }
        List<string> Users = new List<string>();
        List<string> Names = new List<string>();
        List<int> Ages = new List<int>();
        private void UserInfo_Load(object sender, EventArgs e)
        {

        }
        public string Show()
        {
            string output = "Id\tUsers\tNames\tAge\n";
            int index = 0;
            foreach(string user in Users)
            {
                output = output + "" + (index + 1) + "\t" + user + "\t" + Names[index] + "\t" + Ages[index] + "\n ";
                index++;
            }
            return output;
        }
        public bool CheckUser(string user)
        {
            bool check = false;
            foreach(var users in Users)
            {
                if (user == users)
                    check = true;
            }
            return check;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTextBox.Text;
                string user;
                int age;
                if(string.IsNullOrEmpty(userTextBox.Text))
                {
                    MessageBox.Show("Pleace Enter user");
                    return;
                }
                else if(CheckUser(userTextBox.Text))
                {
                    MessageBox.Show("Same user already Exist.Pleace Enter Other user");
                    return;
                }
                else {  user = userTextBox.Text; }
                if (string.IsNullOrEmpty(ageTextBox.Text))
                {
                    MessageBox.Show("Pleace Enter Number Type data In age");
                    return; 
                }
                else { age = Convert.ToInt32(ageTextBox.Text); }
                Names.Add(name);
                Users.Add(user);
                Ages.Add(age);
                outputRichTextBox.Text = Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           

        }
    }
}

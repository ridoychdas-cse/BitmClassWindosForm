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
    public partial class Shop : Form
    {
        
        string[] Name = new string[10];
        int Index = 0;
        
        public Shop()
        {
            InitializeComponent();
        }

        private void Shop_Load(object sender, EventArgs e)
        {

        }
        public string Show()
        {
            string Output = "";
            for(int i=0;i<10;i++)
            {
               if(Name[i]!=null)
                {
                    Output = Output + "Name is :" + Name[i] + "\n ";
                }
            }
            return Output;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            Name[Index] = nameTextBox.Text;
            Index++;
            outputRichTextBox.Text = Show();
           
        }
    }
}

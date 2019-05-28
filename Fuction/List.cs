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
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }
        List<string> Names = new List<string>();
        List<int> Rolls = new List<int>();
        private void AddButton_Click(object sender, EventArgs e)
        {
            Names.Add(nameTextBox.Text);
            Rolls.Add(Convert.ToInt32(rollTextBox.Text));

            nameTextBox.Text = "";
            massageRichTextBox.Text = Show();
        }
        public string Show()
        {
            string massage = "";
            foreach (string Name in Names) 
            {
                int Index = 0;
                massage = massage + "Youre Name is="+Name+Environment.NewLine+"Your Roll Is ="+Rolls[Index]+Environment.NewLine + Environment.NewLine;
                Index++;
            }
            return massage;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            massageRichTextBox.Text = Show();
        }
    }
}

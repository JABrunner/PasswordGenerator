using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        int currentPasswordlength = 0;
        Random character = new Random();
       
        
        
        private void passwordGenerator(int passwordLength)
        {
            String allCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()abcdefghijklmnopqrstuvwxyz";
            String randomPassword = "";

            for (int i = 0; i < passwordLength; i++)
            {
                int randomNum = character.Next(0, allCharacters.Length);
                randomPassword += allCharacters[randomNum];
            }
            PassLabel.Text = randomPassword;
        }
        public Form1()
        {
            InitializeComponent();
            PasswordLengthSlider.Minimum = 5;
            PasswordLengthSlider.Maximum = 20;
            passwordGenerator(5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CopyPassButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(PassLabel.Text);
            progressBar1.Maximum = 100000;
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;
            progressBar1.Style = ProgressBarStyle.Continuous;
            

            for(int i=0; i<100000; i++)
            {
                progressBar1.Value = i;
            }
            MessageBox.Show("Success", "Password Copied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void PasswordLengthSlider_Scroll(object sender, EventArgs e)
        {
            PasswordLength.Text = "Password Length: " + PasswordLengthSlider.Value.ToString();
            currentPasswordlength = PasswordLengthSlider.Value;
            passwordGenerator(currentPasswordlength);
        }

    }
}

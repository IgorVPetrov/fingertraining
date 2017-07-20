using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace training
{
    public partial class Form1 : Form
    {
        Generator generator = new Generator();

        public Form1()
        {
            InitializeComponent();
        }

        void ClearTextBox()
        {
            destTextBox.Enabled = true;
            destTextBox.Focus();
            destTextBox.Text = "";
            destTextBox.BackColor = Color.White;
        }

        void GetNewString()
        {
            sourceLabel.Text = generator.GetNewString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ClearTextBox();
            GetNewString();
        }

        private void IndicateErrorAndRestart()
        {
            destTextBox.Enabled = false;
            destTextBox.BackColor = Color.Red;
            timer.Start();

        }

        private void IndicateSuccessAndResart()
        {
            destTextBox.Enabled = false;
            destTextBox.BackColor = Color.Green;
            timer.Start();
        }

        private void CompareStrings()
        {
            if(destTextBox.Text.Length <= sourceLabel.Text.Length)
            {
                if(sourceLabel.Text.Substring(0,destTextBox.Text.Length) != destTextBox.Text)
                {
                    IndicateErrorAndRestart();
                }
                else if(sourceLabel.Text.Substring(0, destTextBox.Text.Length) == destTextBox.Text && destTextBox.Text.Length == sourceLabel.Text.Length)
                {
                    IndicateSuccessAndResart();
                }

            }
            else
            {
                IndicateErrorAndRestart();

            }
        }


        private void destTextBox_TextChanged(object sender, EventArgs e)
        {
            CompareStrings();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            ClearTextBox();
            GetNewString();

        }
    }
}

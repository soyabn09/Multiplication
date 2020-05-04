using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplication
{
    public partial class Form1 : Form
    {
        int num1; // For first number
        int num2; // For second number
        int answer; // For answer
        int qnum; // For question number

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            qnum = 1; // Question Number 


            // Chooses two numbers from 1 to 10
            Random random = new Random();
            num1 = random.Next(1, 11); 
            num2 = random.Next(1, 11);

            label1.Text = num1 + " X " + num2 + " ="; // Sets the question text for the label

            label6.Text = "Question " + qnum; // Shows the question you are on
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // TEXTBOX
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // CHECK
            answer = num1 * num2; // Calculaes the correct answer

            if (textBox1.Text == answer.ToString()) // Checks if user has the correct anwser in textbox
            {
                // If correct answer then message box to tell user it is correct and update the correct answers label by one
                MessageBox.Show("Correct answer!"); 
                label5.Text = (int.Parse(label5.Text) + 1).ToString();
            }
            else
            {
                // If incorrect answer then message box to tell user it is incorrect, the acual answer and update the incorrect answers label by one
                MessageBox.Show("Incorect answer. The answer was " + answer);
                label4.Text = (int.Parse(label4.Text) + 1).ToString();
            }

            // Sets the textbox blank
            textBox1.Text = "";

            // Chooses two numbers from 1 to 10
            Random random = new Random();
            num1 = random.Next(1, 11);
            num2 = random.Next(1, 11);

            label1.Text = num1 + " X " + num2 + " ="; // Sets the question text for the label

            if (qnum != 10) // Checks if user is on question number 10
            {
                // If not then update question number by one
                qnum += 1;
            }
            else
            {
                // If yes, then disable check button and output message
                button1.Enabled = false;
                MessageBox.Show("Quiz End! \n\nCorrect: " + label5.Text + "/" + qnum + " \n\nIncorrect: " + label4.Text);
            }

            label6.Text = "Question " + qnum; // updates the question you are on label
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

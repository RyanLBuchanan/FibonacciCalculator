using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class FibonacciCalculator : Form
    {
        private long n1 = 0; // Initialize first Fibonacci number
        private long n2 = 1; // Initialize second Fibonacci number
        private int count = 1; // Current Fibonacci number to display 

        public FibonacciCalculator()
        {
            InitializeComponent();
        }

        // Start an async Task to calculate specified Fibonacci number
        private async void calculateButton_Click(object sender, EventArgs e)
        {
            // Retrieve user's input as an integer
            int number = int.Parse(inputTextBox.Text);

            asyncResultLabel.Text = "Calculating...";

            // Task to perform Fibonacci calculation in separate thread
            Task<long> fibonacciTask = Task.Run(() => Fibonacci(number));

            // Wait for Task in separate thread to complete
            await fibonacciTask;

            // Display result after Task in separate thread completes
            asyncResultLabel.Text = fibonacciTask.Result.ToString();   
        }

        // Calculate next Fibonacci number iteratively 
        private void nextNumberButton_Click(object sender, EventArgs e)
        {
            // Calculate the next Fibonacci number 
            long temp = n1 + n2;
            n1 = n2;
            n2 = temp;
            ++count;

            displayLabel.Text = $"Fibonacci of {count}:";
            syncResultLabel.Text = n2.ToString();
        }


        // Calculates nth Fibonacci number recursively
        public long Fibonacci(long n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}

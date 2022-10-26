namespace FibonacciCalculator
{
    public partial class FibonacciTest : Form
    {
        private long n1 = 0; // Initialize first Fibonacci number
        private long n2 = 1; // Initialize second Fibonacci number
        private int count = 1; // Current Fibonacci number to display 

        public FibonacciTest()
        {
            InitializeComponent();
        }

        // Start an async Task to calculate specified Fibonacci number
        

        // Calculate next Fibonacci number iteratively 


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
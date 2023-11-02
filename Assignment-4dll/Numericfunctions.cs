namespace Assignment_4dll
{
    public class Numericfunctions
    {
        public int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
        public int Subtract(int a = 10, int b = 10)
        {
            return a - b;
        }
        public int Multiply(int a = 10, int b = 10)
        {
            return a * b;
        }
        public float Divide(int a = 10, int b = 10)
        {
            float div;
            try
            {
                div = a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine("division by zero not possibe");
            }
            return a / b;
        }
        public int Max(int a = 10, int b = 10)
        {
            if (a > b) { return a; }
            else { return b; }
        }
        public int Min(int a = 10, int b = 10)
        {
            if (a < b) { return a; }
            else { return b; }
        }
        public bool IsEven(int a = 10)
        {
            if (a % 2 == 0) { return true; }
            else { return false; }
        }
        public bool IsOdd(int a = 10)
        {
            if (a % 2 != 0) { return true; }
            else { return false; }
        }
        public bool IsPrime(int a = 10)
        {
            List<int> list = new List<int>();
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0) { list.Add(i); }
                else { continue; }
            }
            if (list.Count == 2)
            {
                return true;
            }
            else { return false; }
        }

    }
}
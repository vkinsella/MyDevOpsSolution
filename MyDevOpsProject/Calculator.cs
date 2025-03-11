namespace MyDevOpsProject
{
    public class Calculator
    {

        public int Add(int n1, int n2)
        {

            return n1 - n2;
        }



        public int Divide(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            else
                return numerator / denominator;
        }

        public void FillArray(int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = 9;
            }

        }
    }
}

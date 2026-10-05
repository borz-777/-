namespace Subjects
{
    public class Math
    {
        public double sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public double div(int num1, int num2)
        {
            if (num2 == 0) return 0; 
            return (double)num1 / num2;
        }

        public double mult(int num1, int num2)
        {
            return num1 * num2;
        }

        public double subtraction(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
using System;
using System.Text;

namespace MentorMateTaskSolution
{
    class Solution
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            if (N % 2 == 0)
            {
                Console.WriteLine("N must be an odd number");
                return;
            }

            int rowCount = (N + 1) / 2;
            
            string leftPart = $"{new string('-', N)}{new string('*', N)}";
            string middlePart = $"{new string('-', N)}";
            string rightPart = $"{new string('*', N)}{new string('-', N)}";
            string shapeToAppend = $"{leftPart}{middlePart}{rightPart}";

            StringBuilder builder = new StringBuilder();
            
            builder.AppendLine($"{shapeToAppend}{shapeToAppend}");

            for (int i = 1, j = 2; i < rowCount; i++, j+= 2)
            {
                leftPart = $"{new string('-', N - i)}{ new string('*', N + j)}";
                middlePart = $"{new string('-', N - j)}";
                rightPart = $"{new string('*', N + j)}{new string('-', N - i)}";

                shapeToAppend = $"{leftPart}{middlePart}{rightPart}";
                builder.AppendLine($"{shapeToAppend}{shapeToAppend}");
            }

            for (int i = 0, j = 1, k = 0;  i < rowCount; i++)
            {
                leftPart = $"{new string('-', N / 2 - i)}{new string('*', N)}";
                middlePart = $"{new string('-', j)}{new string('*', (N * 2) - k - 1)}{new string('-', j)}";
                rightPart = $"{new string('*', N)}{new string('-', N / 2 - i)}";

                shapeToAppend = $"{leftPart}{middlePart}{rightPart}";
                builder.AppendLine($"{shapeToAppend}{shapeToAppend}");

                j += 2;
                k += 2;
            }

            Console.WriteLine(builder.ToString().TrimEnd());
        }
    }
}

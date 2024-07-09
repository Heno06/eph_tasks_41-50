namespace eph_tasks_41_50
{
    internal class Program
    {
        static void Swap(ref float x, ref float y)
        {
            float temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float d = float.Parse(Console.ReadLine());
            float max = 0;
            max =a>b?a:b;
            max = max>c?max:c;
            max = max > d ? max : d;
            Console.WriteLine(max);
            float min = 0;
            min = a < b ? a : b;
            min = min < c ? min : c;
            min = min < d ? min : c;
            Console.WriteLine(min);
            bool one_numberisone = true;
            one_numberisone = a == 1 || b == 1 || c == 1 || d==1? true : false;
            Console.WriteLine(one_numberisone);
            bool sum_is_equal = true; 
            sum_is_equal = a + b == c + d || a + c == b + d || a + d == b + c ? true : false;
            Console.WriteLine(sum_is_equal);
            bool one_equals_three = true;
            one_equals_three = a==b+c+d || b==a+c+d || c==a+b+d || d == a+b+c ? true : false;
            Console.WriteLine(one_equals_three);
            int odd_number = 0;
            odd_number = (a%2==0 && b%2==0) || (c % 2 == 0 && b % 2 == 0) || (c % 2 == 0 && d % 2 == 0) || (b % 2 == 0 && d % 2 == 0) || (a % 2 == 0 && d % 2 == 0) ? 1 : 0;
            Console.WriteLine(odd_number);
            bool  arithmetic_sequence = true;
            arithmetic_sequence = b-a == c-b && c-b == d-c ? true : false;
            Console.WriteLine(arithmetic_sequence);
            bool geometric_sequence = true;
            geometric_sequence = b / a == c / b && c/ b == d / c ? true : false;
            Console.WriteLine(geometric_sequence);
            if (a > b) Swap(ref a, ref b);
            if (a > c) Swap(ref a, ref c);
            if (a > d) Swap(ref a, ref d);
            if (b > c) Swap(ref b, ref c);
            if (b > d) Swap(ref b, ref d);
            if (c > d) Swap(ref c, ref d);
            Console.WriteLine(a+" "+b+ " " + c + " " + d);
            if (a < b) Swap(ref a, ref b);
            if (a < c) Swap(ref a, ref c);
            if (a < d) Swap(ref a, ref d);
            if (b < c) Swap(ref b, ref c);
            if (b < d) Swap(ref b, ref d);
            if (c < d) Swap(ref c, ref d);
            Console.WriteLine(a + " " + b + " " + c + " " + d);



        }
    }
}

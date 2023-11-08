namespace Training.Client.General
{
    public static class hjvaMath
    {

        //https://www.geeksforgeeks.org/print-all-prime-factors-of-a-given-number/
        // A function to print all prime  
        // factors of a given number n 

        public static bool isPalindrome(string s)
        {
            bool ret = true;
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                    ret = false;
            }
            return ret;
        }

        public static long[] primeFactors(long n)
        {
            List<long> result = new();

            // Print the number of 2s that divide n 
            while (n % 2 == 0)
            {
                result.Add(2);
                //Console.Write(2 + " ");
                n /= 2;
            }

            // n must be odd at this point. So we can 
            // skip one element (Note i = i +2) 
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                // While i divides n, print i and divide n 
                while (n % i == 0)
                {
                    result.Add(i);
                    //Console.Write(i + " ");
                    n /= i;
                }
            }

            // This condition is to handle the case when 
            // n is a prime number greater than 2 
            if (n > 2)
            {
                result.Add(n);
                //Console.Write(n);
            }
            return result.ToArray();

        }
    }
} 

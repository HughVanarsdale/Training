namespace Training.Client.General
{
    public static class hjvaMath
    {
        public static bool isPalindrome(string s)
        {
            bool ret = true;        // Return value

            // walk string from position 0 to half way
            // compare first digit with last digit, then second digit with second to last digit...
            // If not the same return false
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1]) { 
                    ret = false;
                    break;
                }
            }
            return ret;
        }
        public static bool isPrime(long n)
        {
            //get all factors for n
            long[] factors = primeFactors(n);

            // if only one factor, they return true, else false.
            return (factors.Length == 1);
        }

        public static long[] primeFactors(long n)
        {
            List<long> result = new();

            if (n == 1)
            {
                result.Add(1);
            }
            else
            {
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
                }
            }
            return result.ToArray();

        }
    }
} 

namespace Training.Client.General
{
    public static class hjvaMath
    {
        public static bool[] SieveOfEratosthenes(int MaxValue)
        {
            bool[] primes = new bool[MaxValue + 1];

            // set all primes to true
            for (int i = 2; i < MaxValue; i++)
            {
                primes[i] = true;
            }

            // for each value up to sqrt of maxvalue
            for (int i = 0; i < Math.Sqrt(MaxValue); i++)
            {
                // if array value is true
                if (primes[i])
                {
                    // find start position for second loop
                    // all non prime values below i^2 will already be set to false.
                    long start = (long)Math.Pow(i, 2);

                    //From start incrementing by i, set primes to false
                    // i.e i=2, start = 4, set 4,6,8,10... to false
                    for (long j = start; j < MaxValue; j += i)
                    {
                        primes[j] = false;

                    }
                }
            }
            return primes;
        }

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
            if (n == 1)
                return false;
            else 
                return (factors.Length == 1);
        }
        public static long[] AllFactors(long n)
        {
            List<long> factors = new();
            long sq = (long)Math.Floor(Math.Sqrt(n));

            factors.Add(1);
            for (int i = 2; i < sq; i++)
            {
                if (n % i == 0)
                {
                    factors.Add(i);
                    factors.Add(n / i);
                }
            }
            factors.Add(n);

            return factors.ToArray();
        }

        public static long[] primeFactors(long n)
        {
            List<long> result = new();

            // Print the number of 2s that divide n 
            while (n % 2 == 0)
            {
                result.Add(2);
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
                    n /= i;
                }
            }

            // This condition is to handle the case when 
            // n is a prime number greater than 2 
            if (n > 2)
            {
                result.Add(n);
            }
            return result.ToArray();

        }
    }
} 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomListLibrary
{
    public class ListNumberService
    {
        private static readonly int[] numbers = new[]
       {
            100, 111, 122, 133, 144
        };

        public List<int> GetRandomList(double maxNumber)
        {            
            List<int> numberlist = new() {100, 111, 122, 133, 144 };

            int sum = numberlist.Sum();

            Random rng = new ();

            for (int i = sum; i < maxNumber - 500;)
            {                
                int number = numbers[rng.Next(numbers.Length)];
                numberlist.Add(number);                
                i += number;
            }

            numberlist = numberlist.OrderBy(a => rng.Next()).ToList();

            numberlist.Add(500);

            return numberlist;
        }       
    }
}

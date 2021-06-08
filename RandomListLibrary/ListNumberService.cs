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
            111, 122, 133, 144
        };

        public List<int> GetRandomList(double maxNumber)
        {
            if (maxNumber < 1010)
            {
                throw new Exception();
            }
            List<int> numberlist = new();
            Random rng = new ();
            int number = 0;
            for (int i = 0; i < maxNumber - 500;)
            {
                var newItem = numbers.Where(x => !numberlist.Any(y => x == y));
                if (i >= 1076 && newItem.Any())
                {
                    foreach (var item in newItem)
                    {
                        number = item;
                        numberlist.Add(item);
                    }
                }
                else
                {
                    number = numbers[rng.Next(numbers.Length)];
                    numberlist.Add(number);
                }
                i += number;
            }
            return numberlist;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class ReversedString
    {
        string sentence = "This is rehtona test";
      
        /// <summary>
        /// If there is any bigger word then five or equal to five reverse it
        /// </summary>
        public string SpinWords()
        {

            string[] words = sentence.Split(' ');
            string[] resultarr = new string[words.Length];
            int i = 0;
            foreach (var item in words)
            {

                char[] charArr = item.ToCharArray();

                if (item.Length >= 5)
                {
                    Array.Reverse(charArr);
                    resultarr[i] = new string(charArr);

                }
                else
                {


                    resultarr[i] = new string(charArr);
                }
                i++;
            }

            string result = string.Join(" ", resultarr);
            return result;
        }


    }
}

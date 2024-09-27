using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoExtensions.NewFolder
{

    //for Extensions it should be static method and class 
    public static class StringExtensions


    {

        public static int WordCount(this string value)
        {

            // it takes how many words are in the senteces
            string[] words = value.Split(' ');

            return words.Length;
        }

        public static List<string> GetWordArray(this string value)

        {
            List<string> words = value.Split(' ').ToList();

            return words;
        }
    }

}
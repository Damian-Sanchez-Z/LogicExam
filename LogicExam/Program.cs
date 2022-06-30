using System;
using System.Collections.Generic;

namespace LogicExam
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            text = text.Replace(" ", "");
            var textLength = text.Length;
            var colRowLength = Math.Sqrt(textLength);
            var array = new List<string>();
            var i = 0;
            var row = "";
            while(text.Length > i)
            {
                if(colRowLength > row.Length)
                {
                    row += text[i];
                }
                else
                {
                    array.Add(row);
                    row = text[i].ToString();
                }
                i++;
            }
            array.Add(row);
            //Console.WriteLine(string.Join("\n",array));

            var returnText = "";
            for (int j = 0; j< Math.Ceiling(colRowLength); j++)
            {
                foreach (var item in array)
                {
                    if(item.Length > j)
                    {
                        returnText += item[j];
                    }
                }
                returnText = j!= colRowLength-1 ? returnText + " ": returnText; 
            }

            Console.WriteLine(returnText);


            Console.ReadLine();
        }
    }
}

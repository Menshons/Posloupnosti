using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posloupnosti
{
    public class ProblemTest
    {
        private BindingList<int> skipNumbers;
        public BindingList<Problem> Problems { get; private set; }

        public ProblemTest()
        {
            Problems = new BindingList<Problem>();
            skipNumbers = new BindingList<int>();
        }

        public void check(Range? range, string text, string skipText, DataGridView grid)
        {
            Problems.Clear();
            skipNumbers.Clear();
            extractSkips(skipText);
            int start = 0;
            int end = 0;
            int errorCount = 0;
            int number = 0;

            if (!String.IsNullOrEmpty(text))
            {
                string[] numbersStr = text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                start = int.Parse(numbersStr[1]);
                end = int.Parse(numbersStr[numbersStr.Length - 1]);
                int index = 1;

                for (int i = start; i <= end; i++)
                {
                    number = int.Parse(numbersStr[index - errorCount]);
                    if (number != i)
                    {
                        if (number == int.Parse(numbersStr[index - errorCount - 1]))
                        {
                            if (!skipNumbers.Contains(number))
                            {
                                Problems.Add(new Problem(number, "Duplicita"));
                            }
                            i--;
                        }
                        else
                        {
                            if (!skipNumbers.Contains(i))
                            {
                                Problems.Add(new Problem(i, "Chybí"));
                            }
                            errorCount++;
                        }
                    }
                    index++;
                }

                if (range != null)
                {
                    Problems = new BindingList<Problem>(Problems.Where(x => x.Number >= range.Start && x.Number <= range.End).ToList());
                    grid.DataSource = Problems;
                }
            }

        }

        private void extractSkips(string skipText)
        {
            if (!String.IsNullOrEmpty(skipText))
            {
                skipText = skipText.Replace(" ", "");
                string[] numbersStr = skipText.Split(',');
                for (int i = 0; i < numbersStr.Length; i++)
                {
                    if(int.TryParse(numbersStr[i], out int number))
                    {
                        skipNumbers.Add(number);
                    } else
                    {
                        string[] rangeArr = numbersStr[i].Split('-');
                        if(rangeArr.Length == 2)
                        {
                            int from = int.Parse(rangeArr[0]);
                            int to = int.Parse(rangeArr[1]);
                            for (int j = from; j <= to; j++)
                            {
                                skipNumbers.Add(j);
                            }
                        }
                    }
                }
            }
        }
    }
}

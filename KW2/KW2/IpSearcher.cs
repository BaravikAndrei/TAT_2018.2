using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KW2
{
    class IpSearcher
    {
        public string SearchIp(string args)
        {
            int counter = 0;
            StringBuilder ip = new StringBuilder();
            string[] textBetwenPoints = args.Split('.');
            for (int i = 1; i < textBetwenPoints.Length; i++)
            {

                if (textBetwenPoints[i].Length < 4 && textBetwenPoints[i].Length > 0)
                {
                    counter++;
                }
                if (textBetwenPoints[i].Length > 4 && textBetwenPoints[i].Length == 0)
                {
                    counter = 0;
                }
                if (counter == 2)
                {
                    if (textBetwenPoints[i - 2].Length > 0)
                    {
                        string substring1 = textBetwenPoints[i - 2].Substring(textBetwenPoints[i - 2].Length - 3);
                        string substring2 = textBetwenPoints[i - 1];
                        string substring3 = textBetwenPoints[i];
                        string substring4 = textBetwenPoints[i + 1].Substring(0, 2);
                        int countNumbers = 0;
                        StringBuilder stringForCheckSymbols = new StringBuilder();
                        stringForCheckSymbols.Append(substring1 + substring2 + substring3 + substring0);
                        foreach (char c in stringForCheckSymbols.ToString())
                        {
                            if (c < '0' || c > '9')
                            {
                                countNumbers++;
                            }
                        }
                        if (countNumbers == stringForCheckSymbols.Length)
                        {
                            if (Int32.Parse(substring1) < 255 && Int32.Parse(substring1) >= 0 &&
                                Int32.Parse(substring2) < 255 && Int32.Parse(substring2) >= 0 &&
                                Int32.Parse(substring3) < 255 && Int32.Parse(substring3) >= 0)&&
                                Int32.Parse(substring4) < 255 && Int32.Parse(substring4) >= 0)
                            {

                ip.Append(substring1 + '.' + substring2 + '.' + substring3 + '.' + substring4 + '\n');
            }
            return ip.ToString();
        }

    }

}





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace training
{
    class Generator
    {
        int maxSymbolsCount = 12;
        int minSymbolsCount = 5;
        int currentSymbolsCount;
        Random random = new Random();

        public IDictionary<int, string> keys = new Dictionary<int, string>(){

            { 0,"0" },
            { 1,"1" },
            { 2,"2" },
            { 3,"3" },
            { 4,"4" },
            { 5,"5" },
            { 6,"6" },
            { 7,"7" },
            { 8,"8" },
            { 9,"9" },
            { 10,"-" },
            { 11,"*" },
            //{ 12,"*" },
            //{ 13,"+" },
            //{ 14,"/" },

            };

        public string GetNewString()
        {
            currentSymbolsCount = random.Next(minSymbolsCount, maxSymbolsCount + 1);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < currentSymbolsCount; i++)
            {
                int currentSymbolCount = random.Next(0, keys.Count);
                sb.Append(keys[currentSymbolCount]);
            }

            return sb.ToString();
        }
    }
}

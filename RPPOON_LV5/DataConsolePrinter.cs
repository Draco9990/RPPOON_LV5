using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RPPOON_LV5
{
    class DataConsolePrinter
    {
        public void PrintDataset(IDataset d)
        {
            ReadOnlyCollection<List<string>> dataset = d.GetData();
            if(dataset == null)
            {
                Console.WriteLine("Dataset is null. This could be because the user was not authorised.");
                return;
            }

            foreach(List<string> stringList in dataset)
            {
                foreach(string s in stringList)
                {
                    Console.Write(s + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

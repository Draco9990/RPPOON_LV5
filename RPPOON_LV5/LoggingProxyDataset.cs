using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RPPOON_LV5
{
    class LoggingProxyDataset : IDataset
    {
        private string filePath;
        private Dataset dataset;
        private ConsoleLogger logger;
        public LoggingProxyDataset(string filePath)
        {
            this.filePath = filePath;
            logger = ConsoleLogger.GetInstance();
        }
        public ReadOnlyCollection<List<string>> GetData()
        {
            logger.Log("Provjera postojanosti dataseta.");
            if (dataset == null)
            {
                logger.Log("Dataset nije pronađen! Kreiranje novog dataseta iz predane lokacije.");
                dataset = new Dataset(filePath);
            }
            else logger.Log("Dataset već postoji.");
            logger.Log("Vraćanje podataka!");
            return dataset.GetData();
        }

    }
}

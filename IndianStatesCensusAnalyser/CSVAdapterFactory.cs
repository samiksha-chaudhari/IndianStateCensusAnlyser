using System;
using System.Collections.Generic;
using System.Text;
using IndianStatesCensusAnalyser.POCO;

namespace IndianStatesCensusAnalyser
{
    class CSVAdapterFactory
    {
        public Dictionary<string, CencusDTO> LoadCsvData(CensusAnalyser.Country country, string csvFilePath, string dataHeaders)
        {
            switch (country)
            {
                case (CensusAnalyser.Country.INDIA):
                    return new IndianCensusAdaptor().LoadCensusData(csvFilePath, dataHeaders);
                default:
                    throw new CensusAnalyserException("No Such Country", CensusAnalyserException.ExceptionType.NO_SUCH_COUNTRY);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using IndianStatesCensusAnalyser.POCO;
using System.Linq;
using Newtonsoft.Json;

namespace IndianStatesCensusAnalyser
{
    class CensusAnalyser
    {
        public enum Country
        {
            INDIA, US, BRAZIL
        }
        Dictionary<string, CencusDTO> dataMap;
        public Dictionary<string, CencusDTO> LoadCensusData(Country country, string csvFilePath, string dataHeaders)
        {
            dataMap = new CSVAdapterFactory().LoadCsvData(country, csvFilePath, dataHeaders);
            return dataMap;
        }
    }
}

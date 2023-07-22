using System.IO;

namespace TrackApp
{
    public class CSVTranslator
    {
        private int NameCol { get; set; }
        private int MoneyCol { get; set; }
        private string CsvPath { get; set; }

        public CSVTranslator(int nameCol, int moneyCol, string path) 
        {
            this.NameCol = nameCol;
            this.MoneyCol = moneyCol;
            this.CsvPath = path;
        }


        public void ReadCSV()
        {
            using (var csvParser = new StreamReader(this.CsvPath))
            {
                while(!csvParser.EndOfStream)
                {
                    var line = csvParser.ReadLine();
                    var values = line.Split(',');

                    if (values.Length > 0)
                    {
                        System.Diagnostics.Debug.WriteLine(values[NameCol]);
                    }
                }
            }
        }
    }
}

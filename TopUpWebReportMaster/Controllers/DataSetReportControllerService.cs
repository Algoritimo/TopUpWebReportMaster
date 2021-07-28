using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using TopUpWebReportMaster.Models;

namespace TopUpWebReportMaster.Controllers {

    public class DataSetReportControllerService {

        // Init file loading
        // file path /Users/kurozetsu/Projects/TopUpWebReportMaster/TopUpWebReportMaster/Data/TOPUP_AQUA_20210101000000_20210131235959.csv
        private string filePath = "./Data/TOPUP_AQUA_20210101000000_20210131235959.csv";

        public void DataSetReportController (string filePath) {
            Console.WriteLine ("File path is " + filePath);
        }

        public List<DataSet> ReturnDataSetInformation () {
            var parsedCsv_2 = new List<DataSet> (){};

            using (TextFieldParser parser = new TextFieldParser (@"/Users/kurozetsu/Projects/TopUpWebReportMaster/TopUpWebReportMaster/Data/TOPUP_AQUA_20210101000000_20210131235959.csv")) {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters (",");

                for (int counter = 0; counter <= 5000; counter++) {
                    // while (!parser.EndOfData) {
                    //Processing row
                    string[] fields = parser.ReadFields ();
                    var input = new DataSet () {
                        ID = fields[0],
                        DATETIME = fields[1],
                        CLIENTNUMBER = fields[2],
                        ENTITYNUMBER = fields[3],
                        DOCUMENTTYPEID = fields[4],
                        DOCUMENTYEAR = fields[5],
                        DOCUMENTNUMBER = fields[6],
                        PROVISIONNUMBER = fields[7],
                        TIMEOUT = fields[8]
                    };
                    parsedCsv_2.Add (input);
                }

            }
            return parsedCsv_2;
        }

    }

}

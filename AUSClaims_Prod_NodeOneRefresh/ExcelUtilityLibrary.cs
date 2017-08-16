using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel;
using System.Data;
using System.IO;

namespace AUSClaims_Prod_NodeOneRefresh
{
    class ExcelUtilityLibrary
    {
        //Method to Read Data from Excel and Parse for Coded UI Test Use
        public static DataTable ExcelToDataTable(string fileName)
        {
            //Open the Excel File and Return Data as Stream
            FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);

            //Create OpenXMLReader via the ExcelReaderFactory
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

            //Set the First Row as the Column Name
            excelReader.IsFirstRowAsColumnNames = true;

            //Return the Excel Data as a Dataset
            DataSet results = excelReader.AsDataSet();

            //Get All the Tables
            DataTableCollection table = results.Tables;

            //Store in the DataTablew
            DataTable resultsTable = table["Admin"];

            return resultsTable;
        }


        public static List<DataCollection> dataCollection = new List<DataCollection>();

        public static void PopulateInCollection(string fileName)
        {
            DataTable table = ExcelToDataTable(fileName);

            //Iterate through the rows and columns of the table
            for (int row = 1; row <= table.Rows.Count; row++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    DataCollection dtTable = new DataCollection()
                    {
                        rowNumber = row,
                        colName = table.Columns[col].ColumnName,
                        colValue = table.Rows[row - 1][col].ToString()
                    };
                    //add all the deatils for each row in the table
                    dataCollection.Add(dtTable);
                }
            }
        }

        public static string ReadData(int rowNumber, string columnName)
        {
            try
            {
                //Retreving Data using LINQ to reduce the interactions
                string data = (from ColData in dataCollection
                               where ColData.colName == columnName && ColData.rowNumber == rowNumber
                               select ColData.colValue).SingleOrDefault();

                return data.ToString();
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }

    public class DataCollection
    {
        public int rowNumber { get; set; }
        public string colName { get; set; }
        public string colValue { get; set; }
    }
}

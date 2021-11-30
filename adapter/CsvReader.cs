using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;


namespace adapter
{
    class CsvReader
    {
        public void ReadBooks() {
            var path = @"Books.csv"; 
            using (TextFieldParser csvParser = new TextFieldParser(path))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { ";" });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvParser.ReadLine();

                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] fields = csvParser.ReadFields();
                    string Author = fields[0];
                    string Name = fields[1];
                    string Year = fields[2];
                    string Genre = fields[3];
                    string Pages = fields[4];
                }


                


            }

            
        }



    }
}

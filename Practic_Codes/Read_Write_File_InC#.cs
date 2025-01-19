using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Practic_Codes
{
    public class Read_Write_File_InC_
    {
        // Read and Write a file using StreamReader and StreamWriter
        string filePath = "Example.txt";
        string content = "Welcome 2025";
        public void Write_File()
        {
            using (StreamWriter streamWriter = new StreamWriter(filePath,true))
            {

                streamWriter.WriteLine(content);
            }
            Console.WriteLine("File written successfully.");
        }
        public void Read_File()
        {
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                // Read from the file
                   string content = streamReader.ReadToEnd();
                Console.WriteLine("File content: " + content);
            }
        }
    }
}

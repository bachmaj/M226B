using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Byte_Array_im_File_sichern_V1_WOd
{
    class Program 
    {
        static void Main(string[] args)
        { 
            // define path and file name
            string fileName = @"c:\Users\bachmaj9\Desktop\byteArray.bin";

            // define and initialize arrays
            byte[] byteArrayWrite = { 200, 201, 202, 203, 204, 205, 206, 207 }; 
            byte[] byteArrayRead = new byte[byteArrayWrite.Length];

            // create file stream
            FileStream fs = new FileStream(fileName, FileMode.Create);

            // write array to file
            fs.Write(byteArrayWrite, 0, byteArrayWrite.Length);

            // read from file
            // set start position
            fs.Position = 0;                             
            fs.Read(byteArrayRead, (int)fs.Position, byteArrayRead.Length);

            // read file values
            for (int count = 0; count < byteArrayRead.Length; count++)
            {
                Console.Write (byteArrayRead[count] + ", ");       
            }
            
            // close filestream
            fs.Close(); 
            // delete file
            File.Delete(fileName);     
        }   
    } 
} 
using System;
using System.IO;
using System.Text;

namespace animals_mobile
{
    public class FileInput
    {
        private string FileName;

        public FileInput(string fileName)
        {
            FileName = fileName;

            try
            {
                using (StreamReader sr = new StreamReader(FileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File Open Error: " + fileName + " " + e);
            }
        }

        public void fileRead()
        {
            string line;
            try
            {
                using (StreamReader sr = new StreamReader(FileName))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File Open Error: " + FileName + " " + e);
            }
        }

        public string fileReadLine()
        {
            try
            {
                using (StreamReader sr = new StreamReader(FileName))
                {
                    return sr.ReadLine();
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File Open Error: " + FileName + " " + e);
                return null;
            }
        }

        public void fileClose()
        {
            //string line;
            try
            {
                using (StreamReader sr = new StreamReader(FileName))
                {
                    sr.Close();
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File Open Error: " + FileName + " " + e);
            }
        }
    }
}
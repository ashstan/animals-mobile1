using System;
using System.IO;

namespace animals_mobile
{
    public class FileOutput
    {
        private string FileName;
        private StreamWriter sw = null;

        public FileOutput(string fileName)
        {
            FileName = fileName;
            try  
            {  
                using (StreamWriter writer = new StreamWriter(fileName))  
                {  
                    //writer.Write("File test");  
                }  
            }  
            catch(Exception e)  
            {  
                Console.Write("File Open Error: " + fileName + " " + e);  
            } 
        }

        public void fileWrite(string line)
        {
            try  
            {  
                using (StreamWriter writer = new StreamWriter(FileName))  
                {  
                    writer.Write(line + "\n");  
                }  
            }  
            catch(Exception e)  
            {  
                Console.Write("File Open Error: " + FileName + " " + e);  
            } 
        }
        
        public void fileClose()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(FileName))
                {
                    sw.Close();
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File Open Error: " + FileName + " " + e);
            }
        }

    }
}
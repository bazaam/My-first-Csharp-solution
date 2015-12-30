using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concept_Testing
{
   public class FileHandler
    {
        double dataReturn;
        string fileName;
        string line;

        public FileHandler(string file)
        {
            fileName = file;
        }


        private void ParseData(string dataTag)
            
        {
            StreamReader file = new StreamReader(fileName);
            try
            {
                    
                while ((line = file.ReadLine()) != null)
                {
                    if (line.StartsWith(dataTag))
                    {
                        dataReturn = Double.Parse(line.Split(':')[1]);
                        break;
                        
                    }
                    
                }

                file.Close();   
            }

            catch(Exception e)
            {

                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            finally
            {
                file.Close();
            }

        }
             
        public double GetData(string dataTag)
        {
            ParseData(dataTag);
            return dataReturn;
        }

    }
}

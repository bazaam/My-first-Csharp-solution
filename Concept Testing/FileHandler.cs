using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concept_Testing
{
   class FileHandler
    {
        double dataReturn;
        string fileName;
        string line;
        void ParseData(string dataTag)

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

            }

            catch
            {
                 ;
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

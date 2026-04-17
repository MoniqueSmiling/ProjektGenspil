using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektGenspil
{
    public abstract class DataHandler
    {
        

        public string FilePath;

        public DataHandler(string filePath) 
        {
            FilePath = filePath;
        }

      
    }
}

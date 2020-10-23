using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnSiteInterview
{
    public class FileSearch
    {
        private string fileNameToSearch;
        private List<string> result = new List<string>();

        public string getFileNameToSearch()
        {
            return fileNameToSearch;
        }
        public void setFileNameToSearch(string fileNameToSearch)
        {
            this.fileNameToSearch = fileNameToSearch;
        }

        public List<string> getResult()
        {
            return result;
        }
    }
}

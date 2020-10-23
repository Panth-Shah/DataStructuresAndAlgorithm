using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithm
{
    public class Program
    {
        static void Main(string[] args)
        {
            //InMemoryFileSystem fs = new InMemoryFileSystem();
            //fs.Mkdir("a/b/c");
            //SimpleFactory sf = new SimpleFactory();
            //sf.makeDoor(9.89, 9.77);
        }
    }

    //public IList<string> Ls(string path)
    //{
    //    //Initialize temp. dictionary pointer to the root directory
    //    FileSearch fs = new FileSearch();
    //    List<string> files = new List<string>();
    //    if (path != "/")
    //    {
    //        //We split the input directory path by '/' to obtain individual level of
    //        //directory names in a d array
    //        string[] d = path.Split('/');
    //        foreach(var directoryName in d)
    //        {
    //            //Traverse over tree directory structure based on individual directories found and
    //            //we keep on updating the t directory pointer to point to the new level of directory(child)
    //            //as we go on entering deeper into the dictioary structure
    //            fs = fs.dirs[directoryName];
    //        }
    //        //At the end, wewill stop at either the end level directory or at the file name
    //        //depending upon the input given. If the last level in the input happens to be a file name
    //        //we simply need to return file name. so we return the last entry of d array
    //        //If last level entry happens to be a dictionary, we can obtain its subdirectory list from
    //        //the list of keys in its dirs Dictionary
    //        //Similarly we cam obtain the list of files in the last directory from the key in the corresponding
    //        //'files' hashmap. We append the two lists obtained, sort them and return the sorted appended list
    //        if (fs.files.ContainsKey(d[d.Length - 1]))
    //        {
    //            files.Add(d[d.Length - 1]);
    //            return files;
    //        }
    //        else
    //        {
    //            fs = fs.dirs[d[d.Length - 1]];
    //        }
    //    }
    //    files.AddRange(new List());
    //}

    #region CreateDictionary
    #endregion

    //public class FileSearch
    //{
    //    private string _fileNameToSearch;
    //    private string _current = "/";
    //    public Dictionary<string, string> files = new Dictionary<string, string>();
    //    public Dictionary<string, FileSearch> dirs = new Dictionary<string, FileSearch>();
    //    private List<string> result = new List<string>();
    //    public FileSearch()
    //    {

    //    }

    //    public string getFileNameToSearch()
    //    {
    //        return _fileNameToSearch;
    //    }

    //    public void setFileNameToSearch(string fileNameToSearch)
    //    {
    //        this._fileNameToSearch = fileNameToSearch;
    //    }

    //    public List<string> getResult()
    //    {
    //        return result;
    //    }

    //    public void searchDirectory()
    //    {

    //    }
    //}
}

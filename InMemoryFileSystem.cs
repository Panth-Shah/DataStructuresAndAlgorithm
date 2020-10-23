using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnSiteInterview
{
    public class InMemoryFileSystem
    {
        private FileItem _root = new FileItem("root", true);

        public InMemoryFileSystem()
        {

        }
        public IList<string> Ls(string path)
        {
            var parts = InMemoryFileSystem.GetPathParts(path);
            var item = GoToItem(parts);
            if (item.isDir)
            {
                return item.Children.Select(kvp => kvp.Value.Name).OrderBy(i => i).ToList();
            }
            else
            {
                var l = new List<string>();
                l.Add(item.Name);
                return l;
            }
        }
        public void Mkdir(string path)
        {
            var parts = InMemoryFileSystem.GetPathParts(path);
            var item = GoToItem(parts, createDir: true);
        }

        public void AddContentToFile(string filePath, string content)
        {
            var parts = InMemoryFileSystem.GetPathParts(filePath);
            var dir = GoToItem(parts.Skip(parts.Length - 1).ToArray(), createDir: true);
            if (!dir.Children.ContainsKey(parts.Last()))
            {
                dir.Children[parts.Last()] = new FileItem(parts.Last(), false);
            }
            dir.Children[parts.Last()].Content += content;
        }

        public string ReeadContentFromFile(string filePath)
        {
            var parts = InMemoryFileSystem.GetPathParts(filePath);
            var items = GoToItem(parts);
            return items.Content;
        }
        //O(M) where M is length of path
        private static string[] GetPathParts(string path)
        {
            var filePaths = path.Split('/');
            if (filePaths.Length > 1 && string.IsNullOrEmpty(filePaths.Last()))
            {
                filePaths = filePaths.Take(filePaths.Length - 1).ToArray();
            }
            return filePaths;
        }

        private FileItem GoToItem(string[] parts, bool createDir = false)
        {
            FileItem rst = _root;
            foreach (var part in parts)
            {
                if (rst.Children.ContainsKey(part))
                {
                    rst = rst.Children[part];
                }
                else
                {
                    if (!createDir)
                    {
                        throw new InvalidOperationException("Intermidiate part is missing" + part);
                    }
                    var dir = new FileItem(part, true);
                    rst.Children[part] = dir;
                    rst = dir;
                }
            }
            return rst;
        }
    }    
    //create comparer
    internal class FileComparer : IComparer<FileItem>
    {
        public int Compare(FileItem x, FileItem y)
        {
            //first by age
            int result = x.Name.CompareTo(y.Name);

            //then name
            if (result == 0)
                result = x.size.CompareTo(y.size);

            //a third sort
            if (result == 0)
                result = x.extension.CompareTo(y.extension);

            return result;
        }
    }

    public class FileItem
    {
        public string Name { get; }
        public bool isDir { get; }
        public string Content { get; set; }
        public string size { get; set; }
        public string extension { get; set; }
        public Dictionary<string, FileItem> Children { get; }
        public FileItem(string name, bool dir, string content = null)
        {
            Name = name;
            isDir = dir;
            if (isDir)
            {
                Children = new Dictionary<string, FileItem>();
            }
            else
            {
                Content = content;
            }
        }
    }
}

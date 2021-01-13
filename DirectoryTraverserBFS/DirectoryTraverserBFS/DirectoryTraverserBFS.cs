using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DirectoryTraverserBFS
{
    /// <summary>
    /// Sample class, which traverses given directory
    /// based on the Breath-First-Search (BFS) algorithm
    /// </summary>
    public static class DirectoryTraverserBFS
    {
        /// <summary>
        /// Traverses and prints given directory with BFS
        /// </summary>
        /// <param name="directoryPath">the path to the directory
        /// which should be traversed</param>
        static void TraverseDir(string directoryPath)
        {
            Queue<DirectoryInfo> visitedDirsQueue = new Queue<DirectoryInfo>();
            visitedDirsQueue.Enqueue(new DirectoryInfo(directoryPath));

            while (visitedDirsQueue.Count > 0)
            {
                DirectoryInfo currentDir = visitedDirsQueue.Dequeue();
                Console.WriteLine(currentDir.FullName);

                DirectoryInfo[] children = currentDir.GetDirectories();
                foreach (DirectoryInfo child in children)
                {
                    visitedDirsQueue.Enqueue(child);

                }

            }
        }
        static void Main()
        {
            TraverseDir(@"D:\\Downloads");
        }
    }
}

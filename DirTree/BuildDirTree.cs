using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirTree
{
    static class BuildDirTree
    {
        private static int depth = 0;
        private static List<string> ExcludedDirsList = new List<string>();

        internal static void InitExcludedDirsList()
        {
            //ExcludedDirsList.Add(@"");
            //ExcludedDirsList.Add(@"");
            //ExcludedDirsList.Add(@"");
            //ExcludedDirsList.Add(@"");
            //ExcludedDirsList.Add(@"");
            //ExcludedDirsList.Add(@"");
            //ExcludedDirsList.Add(@"");
            //ExcludedDirsList.Add(@"");
            //ExcludedDirsList.Add(@"");
            //ExcludedDirsList.Add(@"");
            //ExcludedDirsList.Add(@"");
            //ExcludedDirsList.Add(@"");
            //ExcludedDirsList.Add(@"");
            //ExcludedDirsList.Add(@"");
            //ExcludedDirsList.Add(@"");
            //ExcludedDirsList.Add(@"");
            //ExcludedDirsList.Add(@"");
            ExcludedDirsList.Add(@"C:\Aventus\Trunk\Deployment");
            ExcludedDirsList.Add(@"C:\Aventus\Trunk\log4mongo-net");
            ExcludedDirsList.Add(@"C:\Aventus\Trunk\packages\");
            ExcludedDirsList.Add(@"C:\Aventus\Trunk\packages\knockout");
            ExcludedDirsList.Add(@"C:\Aventus\Trunk\packages\Microsoft.AspNet");
            ExcludedDirsList.Add(@"C:\Aventus\Trunk\RunningTortoise\ThirdParty");
            ExcludedDirsList.Add(@"C:\Aventus\Trunk\Tools");
        }

        internal static void Build(string path)
        {
            if (ExcludedDirsList.Any(s => s.Contains(path)))
            {
                return;
            }

            Console.WriteLine(path.PadLeft(depth));
            foreach (var dir in Directory.GetDirectories(path))
            {
                depth++;
                Build(dir);
                depth--;
            }

        }
    }
}

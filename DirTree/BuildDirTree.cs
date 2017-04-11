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
            ExcludedDirsList.Add(@"C:\Aventus\Trunk\.git");
            ExcludedDirsList.Add(@"C:\Aventus\Trunk\Cloud");
            ExcludedDirsList.Add(@"C:\Aventus\Trunk\CsProjectsDLL");
            ExcludedDirsList.Add(@"C:\Aventus\Trunk\Engineering");
            ExcludedDirsList.Add(@"C:\Aventus\Trunk\FanOut");
            ExcludedDirsList.Add(@"C:\Aventus\Trunk\grpc");
            ExcludedDirsList.Add(@"C:\Aventus\Trunk\Hack");
            ExcludedDirsList.Add(@"C:\Aventus\Trunk\ipch");
            ExcludedDirsList.Add(@"C:\Aventus\Trunk\isp.Aventus.Dashboard");
            ExcludedDirsList.Add(@"C:\Aventus\Trunk\isp.Aventus.LogTail");
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
            if (ExcludedDirsList.Any(s => path.Contains(s)))
            {
                return;
            }

            depth++;
            Console.WriteLine(path.PadLeft(depth));
            foreach (var dir in Directory.GetDirectories(path))
            {
                Build(dir);
            }
            depth--;
        }
    }
}

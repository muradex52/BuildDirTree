using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fclp;

namespace DirTree
{
    class Args
    {
        public string Path { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string path = ParserArgs(args);
            BuildDirTree.InitExcludedDirsList();
            BuildDirTree.Build(path);
        }

        static string ParserArgs(string[] args)
        {
            var parser = new FluentCommandLineParser<Args>();
            parser.Setup(a => a.Path)
                .As('p', "path")
                .Required();

            var result = parser.Parse(args);
            if (result.HasErrors)
            {
                throw new Exception(parser.Object.ToString());
            }

            return parser.Object.Path;
        }
    }
}

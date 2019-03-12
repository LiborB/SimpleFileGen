using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;
using SimpleFileGen;

namespace SimpleFileGen
{
    public class CommandLineOptions
    {
        [Option('s', "size", Required = true, HelpText = "Specify file size (default mb).")]
        public long Size { get; set; } 

        [Option("sizetype", HelpText = "Specify file size type (bit, byte, kb, mb, gb")]
        public string SizeType { get; set; }

        [Option('p', "path", HelpText = "Specify a full path to save the file to. Write only filename to use the current directory.")]
        public string Path { get; set; }

        [Option('o', "overwrite", HelpText = "Set this to allow overwriting existing files.")]
        public bool Overwrite { get; set; }

        [Option("zerofill", HelpText = "Set this option if you want the file data to be zero-filled, instead of random bytes")]
        public bool ZeroFill { get; set; }

    }
}

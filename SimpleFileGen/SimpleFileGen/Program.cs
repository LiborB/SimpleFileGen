using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFileGen
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<CommandLineOptions>(args)
                .WithParsed<CommandLineOptions>(o =>
                {
                    FileGenerator generator = new FileGenerator(o);
                    if (o.SizeType != null)
                    {
                        switch (o.SizeType)
                        {
                            case "bit":
                                generator.GenerateFileWithBits();
                                break;
                            case "byte":
                                generator.GenerateFileWithBytes();
                                break;
                            case "kb":
                                generator.GenerateFileWithKilobytes();
                                break;
                            case "mb":
                                generator.GenerateFileWithMegabytes();
                                break;
                            case "gb":
                                generator.GenerateFileWithGigabytes();
                                break;
                            default:
                                Console.WriteLine("ERROR: Invalid size type specified.");
                                Environment.Exit(0);
                                break;
                        }
                    }
                    else
                    {
                        generator.GenerateFileWithMegabytes();
                    }
                });
        }
    }
}

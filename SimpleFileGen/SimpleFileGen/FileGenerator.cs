using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFileGen
{
    public class FileGenerator
    {
        private CommandLineOptions options;
        private static Random rnd = new Random();
        public FileGenerator(CommandLineOptions options)
        {
            this.options = options;
        }
        public void GenerateFileWithBits()
        {
            ValidatePath(options.Path, options.Overwrite);

            long size = options.Size;

            long byteSize = size / 8;

            byte[] byteArray = new byte[byteSize];
            PopulateByteArray(byteArray);

            File.WriteAllBytes(options.Path, byteArray);


        }

        public void GenerateFileWithBytes()
        {
            ValidatePath(options.Path, options.Overwrite);

            long size = options.Size;

            long byteSize = size;

            byte[] byteArray = new byte[byteSize];
            PopulateByteArray(byteArray);
            File.WriteAllBytes(options.Path, byteArray);


        }

        public void GenerateFileWithKilobytes()
        {
            ValidatePath(options.Path, options.Overwrite);

            long size = options.Size;

            long byteSize = size * 1000;

            byte[] byteArray = new byte[byteSize];
            PopulateByteArray(byteArray);
            File.WriteAllBytes(options.Path, byteArray);


        }

        public void GenerateFileWithMegabytes()
        {
            ValidatePath(options.Path, options.Overwrite);

            long size = options.Size;

            long byteSize = size * (long) Math.Pow(10, 6);

            byte[] byteArray = new byte[byteSize];
            PopulateByteArray(byteArray);
            File.WriteAllBytes(options.Path, byteArray);


        }

        public void GenerateFileWithGigabytes()
        {
            ValidatePath(options.Path, options.Overwrite);

            long size = options.Size;

            long byteSize = size * (long)Math.Pow(10, 9);

            byte[] byteArray = new byte[byteSize];
            PopulateByteArray(byteArray);
            File.WriteAllBytes(options.Path, byteArray);


        }

        private void ValidatePath(string path, bool overwrite)
        {
            if (!Directory.Exists(Path.GetDirectoryName(path)))
            {
                if (path.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
                {
                    Console.WriteLine("ERROR: Specified path does not exist.");
                    Environment.Exit(0);
                }
                
            }

            if (File.Exists(path) && !overwrite)
            {
                Console.WriteLine("ERROR: Cannot overwrite existing file. Enable -o flag to allow overwriting.");
                Environment.Exit(0);
            }
        }

        private void PopulateByteArray(byte[] byteArray)
        {
            if (options.ZeroFill)
            {
                return;
            }
            rnd.NextBytes(byteArray);
        }
    }
}

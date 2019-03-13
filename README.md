# SimpleFileGen
Command line tool to quickly generate files

# Command Line Options

- **-s, --size (required)** = Specify file output size (default is mb).
- **-p, --path (required)** = Specify either a full path or filename for the file.
- **--sizetype** = Specify the type of unit to use for the --size flag. e.g --sizetype=gb. Sizetype is one of the following:
  - bit
  - byte
  - kb
  - mb
  - gb
- **-o, --overwrite** = Enable this option if you want to allow overwriting of files, when the file path already exists
- **-z, --zerofill** = Enable this option if you want the file data to be zero filled (filled with 0's) instead of the default of random data.

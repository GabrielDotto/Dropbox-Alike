using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace GenericFileControl
{
    [Serializable]
    public class CreateCommand : IFileCommand
    {
        public CreateCommand(byte[] byteFile, string name)
        {
            ArrayBytesFile = byteFile;
            FileName = name;
        }

        public override void Command()
        {
            if (!File.Exists(Path))
            {   
                File.WriteAllBytes(Path, ArrayBytesFile);
            }
            else
            {
                File.Delete(Path);
                File.WriteAllBytes(Path, ArrayBytesFile);
            }
        }
    }
}

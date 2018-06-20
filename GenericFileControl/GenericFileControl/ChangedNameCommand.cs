using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GenericFileControl
{
    [Serializable]
    public class ChangedNameCommand : IFileCommand
    {
        public ChangedNameCommand(string name, string oldName, byte[] arrayBytes)
        {
            ArrayBytesFile = arrayBytes;
            NewFileName = name;
            FileName = oldName;
        }

        public override void Command()
        {

            if (File.Exists(Path))
            {
                File.Move(FileName, NewFileName);
            }
            else
            {
                File.WriteAllBytes(NewFileName, ArrayBytesFile);
            }
        }
    }
}

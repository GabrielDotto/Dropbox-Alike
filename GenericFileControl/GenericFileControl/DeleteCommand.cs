using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GenericFileControl
{
    [Serializable]
    public class DeleteCommand : IFileCommand
    {
        public DeleteCommand(string name)
        {
            FileName = name;
        }

        public override void Command()
        {
            if (File.Exists(Path))
            {
                File.Delete(Path);
            }
        }

    }
}

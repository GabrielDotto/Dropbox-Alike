using System;
using System.Collections.Generic;
using System.Text;

namespace GenericFileControl
{
    [Serializable]
    public abstract class IFileCommand
    {
        public byte[] ArrayBytesFile { get; set; }
        public string NewFileName { get; set; }
        public string FileName { get;set; }
        public string Path { get; set; }
        public abstract void Command();
    }
}

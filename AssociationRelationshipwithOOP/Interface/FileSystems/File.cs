using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.FileSystems
{
    public abstract class File:IFileInfo
    {
        public string  FileName { get; set; }
        public string  FileNum { get; set; } 
        public string  CreatedDate { get; set; }
        public string  CreatedBy { get; set; }

        public virtual string GetInfo()
        {
            return $"File Name :{FileName} File Number : {FileNum}\n";
        }
    }
}

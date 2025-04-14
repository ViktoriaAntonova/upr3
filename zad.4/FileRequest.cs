using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad._4
{
    internal class FileRequest
    {
        public string Name { get; set; }
        public FileRequest(string name)
        {
            this.Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}

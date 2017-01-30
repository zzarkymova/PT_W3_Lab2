using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab2_2
{


    class State
    {
        private int index;
        private DirectoryInfo folder;
        public DirectoryInfo Folder
        {
            get { return folder; }
            set
            {
                folder = value;
                MaxIndex = folder.GetDirectories().Length;
            }
        }
        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                if (value >= 0 && value < MaxIndex)
                {
                    index = value;
                }
            }
        }
        public int MaxIndex { get; set; }
    }





    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

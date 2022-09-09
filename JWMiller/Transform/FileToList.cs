// This file is for converting information from a file to a list 

using System;
using System.IO;
using System.IO.File;
using System.Collections;
using System.string; 

namespace JWMiller.Transform
{
    public class File_List ()
    {
        public static List<string> FileToList (string FilePath)
        {
            // Taking file
            private List<string> outList = [];
            foreach (var line in ReadFile(FilePath))
            {
                outList.AddRange(line);
            }
            return outList;
        }
    }
}
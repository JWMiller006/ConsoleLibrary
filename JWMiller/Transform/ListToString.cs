// This file is for converting information from a list to a string

using System;
using System.IO;
using System.IO.File;
using System.Collections;
using System.string; 

namespace JWMiller.Transform
{
    public class File_List ()
    {
        public static string FileToList (List<string> InList, string sepA, string sepB)
        {
            private string outString = "";
            private int count = 1;
            // Taking list and concatonate to string
            foreach (var str in InList)
            {
                // Add to string
                outString += str;
                if (count >= InList.Count)
                {
                    // Final seperator addition
                    outString += sepB;
                }
                else 
                {
                    // Normal seperator addition
                    outString += sepA;
                }
            }
        }
    }
}
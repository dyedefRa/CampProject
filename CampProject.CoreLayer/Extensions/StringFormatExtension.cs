using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampProject.CoreLayer.Extensions
{
   public static class StringFormatExtension
    {
        public static string FirstXLetters(this string content,int first=0,int last=100)
        {
            if (last>content.Length)           
                last = content.Length;           
            return content.Substring(first, last);
        }
    }
}

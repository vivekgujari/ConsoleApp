using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Services
{
    public static class DecodeCommand
    {
        public static string[] Decode(string input)
        {
            if (input == null || input.Length == 0)
                return null;

            return input.Split(' ');
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Services
{
    public static class DecodeCommand
    {
        public static string[] decode(string input)
        {
            if (input.Length == 0 || input == null)
                return null;

            return input.Split(' ');
        }
    }
}

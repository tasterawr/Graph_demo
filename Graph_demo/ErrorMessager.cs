using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_demo
{
    public static class ErrorMessager
    {
        private static string message = "";

        public static string Show(string message)
        {
            return message;
        }

        public static string Message
        {
            get => message;
            set => message = value;
        }
    }
}

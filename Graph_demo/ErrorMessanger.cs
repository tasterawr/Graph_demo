using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_demo
{
    class ErrorMessanger
    {
        private static string message = "";

        public static string Message
        {
            get => message;
            set => message = value;
        }
    }
}

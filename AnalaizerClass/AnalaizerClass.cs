using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalaizerClass
{
    public class AnalaizerClass
    {
        private string expression = "";
        public string lastError { get; private set; }

        public AnalaizerClass(string expression)
        {
            this.expression = expression;
            lastError = "";
        }

    }
}
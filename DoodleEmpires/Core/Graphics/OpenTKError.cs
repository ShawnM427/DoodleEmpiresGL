﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoodleEmpires.Core.Graphics
{
    public class OpenTKException : Exception
    {
        public OpenTKException(string message) : base(message)
        {
        }
    }
}

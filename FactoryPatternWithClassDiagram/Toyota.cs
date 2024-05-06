﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPatternWithClassDiagram
{
    public class Toyota : ICar
    {
        public void Start()
        {
            Console.WriteLine("Toyota Is Starting...");
        }
    }
}
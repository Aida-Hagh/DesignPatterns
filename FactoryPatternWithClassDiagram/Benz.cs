﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPatternWithClassDiagram
{
    public class Benz : ICar
    {
        public void Start()
        {
            Console.WriteLine("Benz Is Starting...");
        }
    }
}
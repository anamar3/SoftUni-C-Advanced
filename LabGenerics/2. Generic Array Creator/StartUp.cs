﻿using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var strings = ArrayCreator.Create(5, "Pesho");
            int[] integers = ArrayCreator.Create(10, 33);

        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TDD.Exam03
{
    public class Logger 
    {
        public Logger()
        {
            Log = "";
        }

        public string Log
        {
            get;
            private set;
        }

        public void Write(string value)
        {
            if (value == null)
            {
                throw new ArgumentException();
            }
            Log += value;
        }
    }
}

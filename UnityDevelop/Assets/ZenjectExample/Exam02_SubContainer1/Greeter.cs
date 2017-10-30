using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZenjectExample.Exam02
{
    public class Greeter
    {
        readonly string _message;

        public Greeter(string message)
        {
            _message = message;
        }

        public void DisplayGreeting()
        {
            Debug.Log(_message);
        }
    }
}

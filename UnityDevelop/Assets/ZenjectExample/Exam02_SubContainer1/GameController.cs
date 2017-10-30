using UnityEngine;
using Zenject;

namespace ZenjectExample.Exam02
{
    public class GameController : IInitializable
    {
        private readonly Greeter _greeter;
        public GameController(Greeter greeter)
        {
            _greeter = greeter;
        }

        public void Initialize()
        {
            _greeter.DisplayGreeting();
        }
    }
}
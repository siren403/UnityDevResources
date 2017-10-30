using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using UniRx;

namespace DI.Exam03
{

    public class TouchInputHandler : IHandleInput, ITickable, IDisposable
    {
        private Subject<Unit> _onContinue = null;
        public Subject<Unit> OnContinue
        {
            get
            {
                return _onContinue ?? (_onContinue = new Subject<Unit>());
            }
        }


        public TouchInputHandler()
        {
            CustomDebug.CDebug.Log("Construct TouchInputHandler");
        }

        public void Tick()
        {
            if (Input.touchCount > 0 &&
                Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                OnContinue.OnNext(Unit.Default);
                OnContinue.OnCompleted();
            }
        }

        public void Dispose()
        {
            _onContinue.Dispose();
        }
    }
}

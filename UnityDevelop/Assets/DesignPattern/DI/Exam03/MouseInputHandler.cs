using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using Zenject;

namespace DI.Exam03
{
    public class MouseInputHandler : IHandleInput, ITickable, IDisposable
    {
        private Subject<Unit> _onContinue = null;
        public Subject<Unit> OnContinue
        {
            get
            {
                return _onContinue ?? (_onContinue = new Subject<Unit>());
            }
        }

        public void Tick()
        {
            if (Input.GetMouseButtonDown(0))
            {
                OnContinue.OnNext(Unit.Default);
                OnContinue.OnCompleted();
            }
        }

        public void Dispose()
        {
            CustomDebug.CDebug.Log("Dispose MouseInputHandler");
            _onContinue.Dispose();
        }
    }

}
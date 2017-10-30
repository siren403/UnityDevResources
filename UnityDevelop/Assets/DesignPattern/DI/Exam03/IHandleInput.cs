using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace DI.Exam03
{
    public interface IHandleInput
    {
        Subject<Unit> OnContinue { get; }   
    }
}

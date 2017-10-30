using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DI.Exam03;
using UniRx;
using UnityEngine.SceneManagement;

namespace ZenjectExample.Exam01
{
    public class GameStateInitialToIntro : IDisposable
    {
        public GameStateInitialToIntro(IHandleInput handleInput)
        {
            handleInput.OnContinue.Subscribe(_ => SwitchNextToGameState());
        }

        private void SwitchNextToGameState()
        {
            SceneManager.LoadScene("ZenjectExample.Exam01.SceneIntro");
        }

        public void Dispose()
        {
            CustomDebug.CDebug.Log("Dispose Intial");
        }
    }
}

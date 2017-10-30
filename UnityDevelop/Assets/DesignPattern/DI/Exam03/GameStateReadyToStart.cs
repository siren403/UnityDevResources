using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace DI.Exam03
{

    public class GameStateReadyToStart 
    {
        public GameStateReadyToStart(IHandleInput inputHandler)
        {
            inputHandler.OnContinue.Subscribe(_ =>
            {
                SwitchToNextGameState();
            });
            CustomDebug.CDebug.Log("Construct GameStateReadyToStart");
        }

        private void SwitchToNextGameState()
        {
            //Logic to Next GameState
            CustomDebug.CDebug.Log("Next GameState");
        }
    }
}

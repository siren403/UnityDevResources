using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Service
{


    public class EditorAudio : IAudio
    {
        public void PlaySound(int soundId)
        {
            CustomDebug.CDebug.LogFormat("play effect : {0}", soundId);
        }

        public void StopSound(int soundId)
        {
            CustomDebug.CDebug.LogFormat("stop effect : {0}", soundId);
        }

        public void StopAllSounds()
        {
            CustomDebug.CDebug.Log("stop all effect");

        }
    }
}

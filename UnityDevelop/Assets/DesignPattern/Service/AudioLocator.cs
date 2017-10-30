using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Service
{

    public class AudioLocator
    {
        private readonly IAudio _audio;

        public AudioLocator(IAudio audio)
        {
            _audio = audio;
            CustomDebug.CDebug.Log("Construct AudioLocator");
        }

        public IAudio GetAudio()
        {
            return _audio;
        }
       
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Service
{
    public interface IAudio
    {
        void PlaySound(int soundId);
        void StopSound(int soundId);
        void StopAllSounds();
    }
}

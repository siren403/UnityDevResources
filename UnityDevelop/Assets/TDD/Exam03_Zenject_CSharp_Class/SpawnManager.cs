using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TDD.Exam03
{
    public class SpawnManager : MonoBehaviour
    {
        public int Count = 0;

        public float IntervalFromFirstSpawn;

        private bool _isSpawned = false;

        public void Spawn()
        {
            if (_isSpawned == false)
                _isSpawned = true;

            Count++;
        }

        void Update()
        {
            if (_isSpawned)
            {
                IntervalFromFirstSpawn += Time.deltaTime;
            }
        }

    }
}

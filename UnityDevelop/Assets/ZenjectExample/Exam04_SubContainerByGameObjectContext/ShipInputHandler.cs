using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace ZenjectExample.Exam04
{
    public class ShipInputHandler : MonoBehaviour
    {
        [Inject]
        private float _speed;

        public void Update()
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                this.transform.position += Vector3.forward * _speed * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                this.transform.position += Vector3.back * _speed * Time.deltaTime;
            }
        }

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZenjectExample.Exam04
{
    public class ShipHealthHandler : MonoBehaviour
    {
        private float _health = 100;

        public void OnGUI()
        {
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200, 100), "Health: " + _health);
        }

        public void TakeDamage(float damage)
        {
            _health -= damage;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace ZenjectExample.Exam04
{
    public class Ship : MonoBehaviour
    {

        private ShipHealthHandler _healthHandler;

        [Inject]
        public void Construct(ShipHealthHandler shipHealthHandler)
        {
            _healthHandler = shipHealthHandler;
        }

        public void TakeDamage(float damage)
        {
            _healthHandler.TakeDamage(damage);
        }

        public class Factory : Factory<float, Ship>
        {

        }
    }
}

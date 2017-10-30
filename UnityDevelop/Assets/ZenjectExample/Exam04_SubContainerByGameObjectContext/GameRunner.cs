using UnityEngine;
using Zenject;

namespace ZenjectExample.Exam04
{

    public class GameRunner : ITickable
    {
        private readonly Ship.Factory _shipFactory;
        private Vector3 _lastShipPosition;

        public GameRunner(Ship.Factory shipFactory)
        {
            _shipFactory = shipFactory;
        }

        public void Tick()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                var ship = _shipFactory.Create(Random.Range(2, 20));
                ship.transform.position = _lastShipPosition;

                _lastShipPosition += Vector3.forward * 2;
            }
        }

    }

}
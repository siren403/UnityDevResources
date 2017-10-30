using UnityEngine;
using Zenject;

namespace ZenjectExample.Exam04
{
    public class ShipInstaller : MonoInstaller<ShipInstaller>
    {
        [Inject] private float _speed;

        public override void InstallBindings()
        {
            Container.BindInstance(_speed).WhenInjectedInto<ShipInputHandler>();
        }
    }
}
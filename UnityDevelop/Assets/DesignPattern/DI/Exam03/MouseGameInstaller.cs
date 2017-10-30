using UnityEngine;
using Zenject;

namespace DI.Exam03
{

    public class MouseGameInstaller : MonoInstaller<MouseGameInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<MouseInputHandler>().AsCached();
            Container.Bind<GameStateReadyToStart>().AsTransient();

            Container.Resolve<GameStateReadyToStart>();
        }
    }
}
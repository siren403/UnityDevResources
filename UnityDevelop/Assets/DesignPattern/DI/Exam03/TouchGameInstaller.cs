using UnityEngine;
using Zenject;

namespace DI.Exam03
{
    public class TouchGameInstaller : MonoInstaller<TouchGameInstaller>
    {
        public override void InstallBindings()
        {
            //각기 다른 인스턴스로 생성됨
            //Container.Bind<IHandleInput>().To<TouchInputHandler>().AsCached();
            //Container.Bind<ITickable>().To<TouchInputHandler>().AsCached();

            //해당 타입이 상속받은 인터페이스를 모두 바인드
            Container.BindInterfacesTo<TouchInputHandler>().AsCached();
            Container.Bind<GameStateReadyToStart>().AsTransient().NonLazy();

        }
    }
}
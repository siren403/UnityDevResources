using UnityEngine;
using Zenject;

namespace ZenjectExample.Exam02
{
    public class TestInstaller : MonoInstaller<TestInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<GameController>().AsSingle();

            //Container.Bind<Greeter>().FromSubContainerResolve().ByMethod(InstallGreeter).AsSingle();

            //대상 바인드 타입을 서브컨테이너를 통해 바인드
            Container.Bind<Greeter>().FromSubContainerResolve().ByInstaller<GreeterInstaller>().AsSingle();
        }

        void InstallGreeter(DiContainer subContainer)
        {
            subContainer.Bind<Greeter>().AsSingle();
            subContainer.BindInstance("Hello World");

        }
    }

}
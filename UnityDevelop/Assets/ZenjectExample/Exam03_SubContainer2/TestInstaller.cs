using UnityEngine;
using Zenject;

namespace ZenjectExample.Exam03
{
    public class TestInstaller : MonoInstaller<TestInstaller>
    {
        public override void InstallBindings()
        {

            Container.BindInterfacesAndSelfTo<Greeter>()
                .FromSubContainerResolve().ByInstaller<GreeterInstaller>().AsSingle().NonLazy();

        }
    }
}
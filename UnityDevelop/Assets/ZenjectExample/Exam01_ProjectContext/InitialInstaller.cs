using UnityEngine;
using Zenject;
using DI.Exam03;

namespace ZenjectExample.Exam01
{
    public class InitialInstaller : MonoInstaller<InitialInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<MouseInputHandler>().AsCached();
            Container.BindInterfacesTo<GameStateInitialToIntro>().AsTransient().NonLazy();
        }
    }
}
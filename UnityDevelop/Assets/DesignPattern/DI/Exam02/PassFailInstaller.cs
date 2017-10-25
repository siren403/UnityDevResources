using UnityEngine;
using Zenject;

namespace DI.Exam02
{

    public class PassFailInstaller : MonoInstaller<PassFailInstaller>
    {

        public override void InstallBindings()
        {
            Container.Bind<Client>().AsSingle().NonLazy();
            Container.Bind<Grader>().To<PassFailGrader>().AsSingle();
            //Container.Bind<PassFailGrader>().AsSingle();
        }
    }
}
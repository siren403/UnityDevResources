using UnityEngine;
using Zenject;
namespace DI.Exam02
{

    public class StandardInstaller : MonoInstaller<StandardInstaller>
    {

        public override void InstallBindings()
        {
            Container.Bind<Client>().AsSingle().NonLazy();
            Container.Bind<Grader>().To<StandardGrader>().AsSingle();
            //Container.Bind<StandardGrader>().AsSingle();
        }
    }
}
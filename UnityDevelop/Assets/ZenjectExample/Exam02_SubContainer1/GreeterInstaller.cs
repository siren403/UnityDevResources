using UnityEngine;
using Zenject;

namespace ZenjectExample.Exam02
{
    public class GreeterInstaller : Installer<GreeterInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<Greeter>().AsSingle();
            Container.BindInstance("Hello World");
        }
    }
}
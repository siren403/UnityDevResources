using System;
using System.Collections;
using System.Collections.Generic;
using ModestTree;
using UnityEngine;
using Zenject;

namespace ZenjectExample.Exam03
{

    public class GoodbyeHandler : IDisposable
    {
        public void Dispose()
        {
            Log.Trace("Goodbye World!");
        }
    }

    public class HelloHandler : IInitializable
    {
        public void Initialize()
        {
            Log.Trace("Hello world!");
        }
    }

    public class Greeter : Kernel
    {
        public Greeter()
        {
            Debug.Log("Created Greeter!");
        }
    }

    public class GreeterInstaller : Installer<GreeterInstaller>
    {

     

        public override void InstallBindings()
        {
            Container.Bind<Greeter>().AsSingle();

            Container.BindInterfacesTo<GoodbyeHandler>().AsSingle();
            Container.BindInterfacesTo<HelloHandler>().AsSingle();
        }
    }
}

using UnityEngine;
using Zenject;

namespace Service
{
    public class AudioInstaller : MonoInstaller<AudioInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<AudioLocator>().AsSingle().NonLazy();
            CustomDebug.CDebug.Log("Bind AudioLocator");

            Container.Bind<IAudio>().To<EditorAudio>().AsSingle();

            //Container.Resolve<AudioLocator>().GetAudio().PlaySound(10);
            //Container.Resolve<AudioLocator>().GetAudio().PlaySound(11);
        }
    }
}
using UnityEngine;
using Zenject;

namespace ZenjectExample.Exam01
{
    public class IntroInstaller : MonoInstaller<IntroInstaller>
    {
        public override void InstallBindings()
        {
            CustomDebug.CDebug.Log("Install Intro");
            Container.Resolve<Service.AudioLocator>().GetAudio().PlaySound(0);
        }
    }
}
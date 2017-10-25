using UnityEngine;
using Zenject;

namespace DI.Exam02
{

    [CreateAssetMenu(fileName = "ClientSettingsInstaller", menuName = "Installers/ClientSettingsInstaller")]
    public class ClientSettingsInstaller : ScriptableObjectInstaller<ClientSettingsInstaller>
    {
        public Client.Settings ClientSettings = null;

        public override void InstallBindings()
        {
            Container.BindInstance(ClientSettings);
        }
    }

}
using UnityEngine;
using Zenject;

namespace ZenjectExample.Exam04
{
    public class GameInstaller : MonoInstaller<GameInstaller>
    {
        [SerializeField] private GameObject _shipPrefab;

        public override void InstallBindings()
        {
            Container.BindInterfacesTo<GameRunner>().AsSingle();

            Container.BindFactory<float, Ship, Ship.Factory>()
                .FromSubContainerResolve().ByNewPrefab<ShipInstaller>(_shipPrefab);

        }
    }
}
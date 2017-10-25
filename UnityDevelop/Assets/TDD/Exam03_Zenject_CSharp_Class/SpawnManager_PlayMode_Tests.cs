using Zenject;
using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace TDD.Exam03
{
    public class SpawnManager_PlayMode_Tests : ZenjectIntegrationTestFixture
    {
        [SetUp]
        public void Installs()
        {
            PreInstall();

            Container.Bind<SpawnManager>().FromNewComponentOnNewGameObject().AsSingle();

            PostInstall();
        }

        [Inject] private SpawnManager _spawnManager;

        [UnityTest]
        public IEnumerator _Spawn_Interval_Timer()
        {
            _spawnManager.Spawn();

            yield return new WaitForSeconds(0.3f);

            Assert.IsTrue(_spawnManager.IntervalFromFirstSpawn <= 1.0f);
        }
    }
}
using Zenject;
using NUnit.Framework;

namespace TDD.Exam03
{
    [TestFixture]
    public class SpawnManager_Tests : ZenjectUnitTestFixture
    {
        [SetUp]
        public void Installs()
        {
            Container.Bind<SpawnManager>().FromNewComponentOnNewGameObject().AsSingle();
            Container.Inject(this);
        }

        [Inject] private SpawnManager _spawnManager;

        [Test]
        public void _Initial()
        {
            Assert.NotNull(_spawnManager);
        }

        [Test]
        public void _Spawn()
        {
            _spawnManager.Spawn();
            Assert.AreEqual(_spawnManager.Count, 1);
        }
    }
}
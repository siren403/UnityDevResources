using NSubstitute;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.TestTools;

namespace TDD.Exam02
{

    public class EnemySpawner_Tests
    {

        /// <summary>
        /// 전달한 프리펩에 맞는 인스턴스가 생성되는지
        /// </summary>
        /// <returns></returns>
        [UnityTest]
        public IEnumerator _Instantiantes_GameObject_From_Prefab()
        {
            var enemySpawner = new GameObject().AddComponent<EnemySpawner>();
            var enemyPrefab = Resources.Load("Tests/Enemy");
            enemySpawner.Construct(enemyPrefab, 0, 1);

            yield return null;

            var spawnedEnemy = GameObject.FindWithTag("Enemy");
            //전달한 인스턴스의 원본 프리펩의 정보를 가져옴
            var prefabOfTheSpawnedEnemy = PrefabUtility.GetPrefabParent(spawnedEnemy);

            //로드한 프리펩과 인스턴스를 통해 가져온 프리펩이 일치하는지 검사
            //불일치하면 예외 발생
            Assert.AreEqual(enemyPrefab, prefabOfTheSpawnedEnemy);
        }

        /// <summary>
        /// 각도에 맞는 포지션에 생성이 되는지
        /// </summary>
        /// <returns></returns>
        [UnityTest]
        public IEnumerator _Instantiates_GameObject_At_Random_Position_On_Circle_Boundary()
        {
            var enemySpawner = new GameObject().AddComponent<EnemySpawner>();
            var enemyPrefab = Resources.Load("Tests/Enemy");
            enemySpawner.Construct(enemyPrefab, 0, 1);
            var random = Substitute.For<System.Random>();
            random.Next(Arg.Any<int>(), Arg.Any<int>()).Returns(270);
            enemySpawner.Random = random;

            yield return null;

            var spawnedEnemy = GameObject.FindWithTag("Enemy");
            var expectedPosition = new Vector3(0, 0, -1);

            Assert.AreEqual(expectedPosition, spawnedEnemy.transform.position);
        }


        /// <summary>
        /// 지정한 인터벌에 맞게 생성이 되는지
        /// </summary>
        /// <returns></returns>
        [UnityTest]
        public IEnumerator _Instantiations_Occur_On_An_Interval()
        {

            var enemySpawner = new GameObject().AddComponent<EnemySpawner>();
            var enemyPrefab = Resources.Load("Tests/Enemy");
            enemySpawner.Construct(enemyPrefab, 1, 1);

            yield return new WaitForSeconds(0.75f);

            var spawnedEnemy = GameObject.FindWithTag("Enemy");

            //Null이 아니면 예외 발생
            Assert.IsNull(spawnedEnemy);
        }

        [TearDown]
        public void AfterEveryTest()
        {
            foreach (var gameObject in GameObject.FindGameObjectsWithTag("Enemy"))
                Object.Destroy(gameObject);
            foreach (var gameObject in Object.FindObjectsOfType<EnemySpawner>())
                Object.Destroy(gameObject);
        }
    }
}

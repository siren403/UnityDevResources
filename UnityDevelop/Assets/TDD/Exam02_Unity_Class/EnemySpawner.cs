using UnityEngine;
using UnityEditor;
using Random = System.Random;

namespace TDD.Exam02
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private Object _enemyPrefab;
        [SerializeField] private float _spawnRate;
        [SerializeField] private int _radius;

        private float _timeSinceLastSpawn;
        private Circle _circle;
        public Random Random { get; set; }

        public void Construct(Object enemyPrefab, float spawnRate, int radius)
        {
            _enemyPrefab = enemyPrefab;
            _spawnRate = spawnRate;
            _circle = new Circle(radius);
        }

        private void Update()
        {
            if(_circle == null)
                _circle = new Circle(_radius);

            if (Random == null)
                Random = new Random();

            if (_timeSinceLastSpawn >= _spawnRate)
            {

                //PrefabUtility.InstantiatePrefab를 사용하면 원본프리펩과의 연결이 끊어지지 않은채로 생성됨
                var enemy = PrefabUtility.InstantiatePrefab(_enemyPrefab) as GameObject;

                var degrees = Random.Next(0, 361);

                enemy.transform.position = _circle.GetPositionOnBoundaryOfCircle(degrees);

                _timeSinceLastSpawn = 0;
            }

            _timeSinceLastSpawn += Time.deltaTime;
        }
    }
}

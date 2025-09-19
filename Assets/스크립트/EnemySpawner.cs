using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // 적 프리팹 연결
    public float spawnInterval = 2f; // 생성 간격(초)

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, spawnInterval);
    }

    void SpawnEnemy()
    {
        // 랜덤한 원형 위치에 적 생성
        Vector2 spawnPos = (Vector2)transform.position + Random.insideUnitCircle.normalized * 8f;
        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
}

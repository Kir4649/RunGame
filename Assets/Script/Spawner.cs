using UnityEngine;
using System.Collections;


public class Spawner : MonoBehaviour
{
    public GameObject wallPrefab;//壁のプレハブ
    public Transform[] spawnPoints; // 3つのスポーン位置
    public float minSpawnInterval = 1.5f;//
    public float maxSpawnInterval = 3f;//

    void Start()
    {
        StartCoroutine(SpawnWalls());
    }

    IEnumerator SpawnWalls()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnInterval, maxSpawnInterval));
            int wallCount = Random.Range(1, 3);//出現する壁の数
            int[] indices = {0, 1, 2};
            // シャッフル
            for (int i = 0; i < indices.Length; i++)
            {
                int rand = Random.Range(i, indices.Length);
                (indices[i], indices[rand]) = (indices[rand], indices[i]);
            }
            // ランダムレーンに壁生成
            for (int i = 0; i < wallCount; i++)
            {
                Transform spawnPoint = spawnPoints[indices[i]];
                Instantiate(wallPrefab, spawnPoint.position, spawnPoint.rotation);
            }
        }
    }
}

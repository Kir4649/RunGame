using UnityEngine;
using UnityEngine.Rendering;

public class TImeSpawner : MonoBehaviour
{
    public GameObject[] wallPrefabs;
    public Transform[] spawnPoints;

    private float timer = 0f;
    private float IntervalTime = 2.0f;
    TimeCounter countdown;

    private void Start()
    {
        countdown = GetComponent<TimeCounter>();
        Time.timeScale = 1.2f;
    }

    void Update()
    {

        // 時間を進める
        timer += Time.deltaTime;

        // 一定時間たったらスポーン
        if (timer >= IntervalTime)
        {
            SpawnWall();

            // タイマーリセット
            timer = 0f;

            // だんだん速くする
            if (IntervalTime > 1.2f)
            {
                IntervalTime -= 0.1f;
            }
        }
        //if(countdown < )
        //{

        //}

    }

    void SpawnWall()
    {
        int wallCount = Random.Range(1, 4);

        int[] indices = { 0, 1, 2 };

        // シャッフル
        for (int i = 0; i < indices.Length; i++)
        {
            int rand = Random.Range(i, indices.Length);
            (indices[i], indices[rand]) = (indices[rand], indices[i]);
        }

        for (int i = 0; i < wallCount; i++)
        {
            Transform spawnPoint = spawnPoints[indices[i]];

            if (i == 2)
            {
                Instantiate(
                    wallPrefabs[0],
                    spawnPoint.position,
                    wallPrefabs[0].transform.rotation
                );
            }
            else
            {
                GameObject randomWall =
                    wallPrefabs[Random.Range(0, wallPrefabs.Length)];

                Instantiate(
                    randomWall,
                    spawnPoint.position,
                    randomWall.transform.rotation
                );
            }
        }
    }
}

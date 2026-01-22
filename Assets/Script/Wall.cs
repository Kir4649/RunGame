using UnityEngine;

public class Wall : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float maxSpeed = 15f;
    public TimeCounter timeCounter; // TimeCounter参照
    public float maxTime = 5f;   // TimeCounter と同じ値


    void Start()
    {
        timeCounter = FindObjectOfType<TimeCounter>();
        Destroy(gameObject, 3f); // 3秒後に自動削除
    }

    // Update is called once per frame
    void Update()
    {
        if (timeCounter == null) return;

        float t = Mathf.Clamp01(timeCounter.countdown / maxTime);
        float speed = Mathf.Lerp(moveSpeed,maxSpeed, 1 - t);

        // プレイヤー方向へ動く（Zマイナス方向）
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime, Space.World);
    }
}

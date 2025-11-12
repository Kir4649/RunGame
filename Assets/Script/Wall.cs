using UnityEngine;

public class Wall : MonoBehaviour
{
    public float moveSpeed = 10f;
    void Start()
    {
        Destroy(gameObject, 3f); // 3秒後に自動削除
    }

    // Update is called once per frame
    void Update()
    {
        // プレイヤー方向へ動く（Zマイナス方向）
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
    }
}

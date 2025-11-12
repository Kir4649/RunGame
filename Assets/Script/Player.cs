using UnityEngine;

public class Player : MonoBehaviour
{
    public float laneDistance = 2.5f; //レーン間の距離
    private int currentLane = 1; //0:左, 1:中央, 2:右

    private float targetX; //移動先

    void Start()
    {
        targetX = 0;//最初のスタート地点
    }

    // Update is called once per frame
    void Update()
    {
        HandleInput(); // 入力処理
        MoveToLane();// X方向にスムーズに移動
        //MoveForward(); // 前進処理
    }
    void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            currentLane = Mathf.Max(0, currentLane - 1); // 左へ
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            currentLane = Mathf.Min(2, currentLane + 1); // 右へ
        }

        targetX = (currentLane - 1) * laneDistance; // 位置更新
    }
    void MoveToLane()
    {
        Vector3 pos = transform.position;
        pos.x = Mathf.Lerp(pos.x, targetX, Time.deltaTime * 10f);
        transform.position = pos;
    }
    void MoveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 10f);
    }
}

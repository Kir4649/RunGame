using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float laneDistance = 2f; //レーン間の距離
    private int currentLane = 1; //0:左, 1:中央, 2:右
    public float jumpForce = 7f;      // ジャンプ力
    public LayerMask groundLayer;     // 地面のレイヤーを指定
    public Transform groundCheck;     // 足元のチェック位置
    public float groundCheckRadius = 0.2f;
    private float targetX; //移動先

    private Rigidbody rb;
    private bool isGrounded;
  
    public GameObject Gameover;
    void Start()
    {
        if (Gameover != null) Gameover.SetActive(false);
        rb = GetComponent<Rigidbody>(); 
        targetX = 0;//最初のスタート地点
        Gameover.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        HandleInput(); // 入力処理
        MoveToLane();// X方向にスムーズに移動
        Jump();
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

    void Jump()
    {
        // 地面に接地しているか確認
        isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, groundLayer);

        // スペースキーでジャンプ
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Wall"))
        {
            Time.timeScale = 0;
            if (Gameover != null) Gameover.SetActive(true);
           
        }
        if (Input.GetKeyDown("enter"))
        {
            SceneManager.LoadScene("StartScenes");
        }
    }

}

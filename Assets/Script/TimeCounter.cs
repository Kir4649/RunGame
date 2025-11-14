using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    public float countdown = 5.0f;//制限時間を設定

    public Text timeText;//秒数を表示
    public GameObject GameClear;
    // Update is called once per frame

    private void Start()
    {
        if (GameClear != null) GameClear.SetActive(false);
    }
    void Update()
    {
        //カウントダウンする
        countdown -= Time.deltaTime;

        //時間を表示する
        timeText.text = countdown.ToString("f1") + "秒";

        //countdownが0以下になった時
        if (countdown <= 0)
        {
            countdown = 0;
            if (GameClear != null) GameClear.SetActive(true);
           
        }
    }
}

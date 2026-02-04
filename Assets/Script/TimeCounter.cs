using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    public float countdown = 5.0f;//制限時間を設定

    public Text timeText;//秒数を表示
    public GameObject GameClear;
    // Update is called once per frame
    [SerializeField]
    private GameObject BlackWall;//暗転する画面

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
            StartCoroutine(Clear());


        }
    }
    private IEnumerator Clear()
    {
        while (true)
        {
            if (BlackWall.GetComponent<Image>().color.a != 1)
            {
                BlackWall.GetComponent<Image>().color += new Color(0, 0, 0, Time.deltaTime / 2);
                if (BlackWall.GetComponent<Image>().color.a >= 1)
                {
                    Time.timeScale = 0;

                    SceneManager.LoadScene("EndScenes");
                }
            }
            yield return null;
        }
    }
}

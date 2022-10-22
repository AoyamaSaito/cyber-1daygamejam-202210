using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    [SerializeField] TweetsData _tweet;
    [SerializeField] Text _timerText;
    [SerializeField] Text _countDownText;
    [Tooltip("カウントダウン時にクリックの入力を受け付けないように")]
    [SerializeField] Image _panel;

    public static float Timer { get; set; }
    int _biginningDark; //闇ツイート(初期値)
    public int BiginningDark { get => _biginningDark; set => _biginningDark = value; }
    /// <summary> 闇ツイート </summary>
    public int DarkTweet { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        Timer = 0;
        BiginningDark = DarkTweet = _tweet.Dark;
        StartCoroutine(StartCount());
    }

    // Update is called once per frame
    void Update()
    {
        if (!_panel.gameObject.activeSelf)
        {
            Timer += Time.deltaTime;
            _timerText.text = Timer.ToString("F1");
        }

        if (DarkTweet == 0)
        {
            SceneManager.LoadScene("ResultTest");
        }
    }

    /// <summary> 闇ツイートの数をリセットする </summary>
    public void TweetReset()
    {
        Timer = 0;
        DarkTweet = BiginningDark;
    }

    /// <summary> 闇ツイートのカウントを減らす </summary>
    public void Count()
    {
        DarkTweet--;
    }

    /// <summary>ゲーム開始のカウントダウンをするコルーチン</summary>
    IEnumerator StartCount()
    {
        for (int i = 3; i >= 0; i--)
        {
            if (i != 0) _countDownText.text = $"{i}";
            else        _countDownText.text = "Start";

            yield return new WaitForSeconds(1);
        }

        _countDownText.text = "";
        _panel.gameObject.SetActive(false);
    }
}

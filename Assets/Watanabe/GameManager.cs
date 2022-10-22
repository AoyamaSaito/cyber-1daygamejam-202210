using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    //TweetsData _tweet;
    [SerializeField] Text _darkTweetCountText;
    [SerializeField] Text _timerText;
    [SerializeField] Text _countDownText;
    [Tooltip("カウントダウン時に干渉しないように")]
    [SerializeField] Image _panel;

    float _timer;
    public float Timer { get => _timer; set => _timer = value; }
    int _biginningDark; //闇ツイート(初期値)
    public int BiginningDark { get => _biginningDark; set => _biginningDark = value; }
    /// <summary> 闇ツイート </summary>
    public int DarkTweet { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        //_tweet = GameObject.Find("GameObject").GetComponent<TweetsData>();
        BiginningDark = DarkTweet = 5; /* = _tweet.Dark*/
        StartCoroutine(StartCount());
    }

    // Update is called once per frame
    void Update()
    {
        _darkTweetCountText.text = DarkTweet.ToString();

        if (!_panel.gameObject.activeSelf)
        {
            Timer += Time.deltaTime;
            _timerText.text = Timer.ToString("F1");

            if (Input.GetMouseButtonDown(0))
            {
                DarkTweet--;
            }
        }

        if (DarkTweet == 0)
        {
            _panel.gameObject.SetActive(true);
            Invoke("LoadScene", 1f);
        }
    }

    /// <summary> クリア画面に遷移(闇ツイート0で呼び出す) </summary>
    void LoadScene()
    {
        SceneManager.LoadScene("ResultTest");
    }

    /// <summary> 闇ツイートの数をリセットする </summary>
    public void TweetReset()
    {
        Timer = 0;
        DarkTweet = BiginningDark;
    }

    public void Count()
    {
        DarkTweet--;
    }

    /// <summary>ゲーム開始のカウントをするコルーチン</summary>
    IEnumerator StartCount()
    {
        _countDownText.text = "3";
        yield return new WaitForSeconds(1);
        _countDownText.text = "2";
        yield return new WaitForSeconds(1);
        _countDownText.text = "1";
        yield return new WaitForSeconds(1);
        _countDownText.text = "Start";

        yield return new WaitForSeconds(1);
        _countDownText.text = "";
        _panel.gameObject.SetActive(false);
    }
}

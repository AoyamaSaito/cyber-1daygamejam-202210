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
    [Tooltip("�J�E���g�_�E�����ɃN���b�N�̓��͂��󂯕t���Ȃ��悤��")]
    [SerializeField] Image _panel;

    public static float Timer { get; set; }
    int _biginningDark; //�Ńc�C�[�g(�����l)
    public int BiginningDark { get => _biginningDark; set => _biginningDark = value; }
    /// <summary> �Ńc�C�[�g </summary>
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

    /// <summary> �Ńc�C�[�g�̐������Z�b�g���� </summary>
    public void TweetReset()
    {
        Timer = 0;
        DarkTweet = BiginningDark;
    }

    /// <summary> �Ńc�C�[�g�̃J�E���g�����炷 </summary>
    public void Count()
    {
        DarkTweet--;
    }

    /// <summary>�Q�[���J�n�̃J�E���g�_�E��������R���[�`��</summary>
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

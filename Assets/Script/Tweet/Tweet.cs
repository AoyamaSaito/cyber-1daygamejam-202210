using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tweet : MonoBehaviour
{
    [Header("名前")]
    [SerializeField]
    private string _name = "名無しさん";
    [SerializeField]
    private Text _nameText;
    [Header("本文")]
    [SerializeField]
    private string _sentence = "";
    [SerializeField]
    private Text _sentenceText;
    [Header("日時")]
    [SerializeField]
    private string _date = "20XX/XX/XX";
    [SerializeField]
    private Text _dateText;
    [Header("黒歴史かどうか")]
    [SerializeField]
    private bool _isDark = false;

    private GameManager _gameManager;

    private void Start()
    {
        _gameManager = GameManager.Instance;

        if(_nameText)
        {
            _nameText.text = _name;
        }

        if(_sentenceText)
        {
            _sentenceText.text = _sentence;
        }

        if(_dateText)
        {
            _dateText.text = _date;
        }
    }

    /// <summary>
    /// ボタンで呼び出す
    /// </summary>
    public void DarkCheck()
    {
        Destroy(gameObject);
        if(_isDark == true)
        {
            _gameManager.Count();
        }
    }
}

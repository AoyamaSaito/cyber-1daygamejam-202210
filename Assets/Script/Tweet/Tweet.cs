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
    [Header("黒歴史かどうか")]
    [SerializeField]
    private bool _isDark = false;

    private void Start()
    {
        if(_nameText)
        {
            _nameText.text = _name;
        }

        if(_sentenceText)
        {
            _sentenceText.text = _sentence;
        }
    }

    /// <summary>
    /// ボタンで呼び出す
    /// </summary>
    public void DarkCheck()
    {
        if(_isDark == true)
        {
            //GameManagerとかに値を入れる
        }
        else
        {

        }
    }
}

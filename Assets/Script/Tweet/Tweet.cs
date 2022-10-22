using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tweet : MonoBehaviour
{
    [Header("���O")]
    [SerializeField]
    private string _name = "����������";
    [SerializeField]
    private Text _nameText;
    [Header("�{��")]
    [SerializeField]
    private string _sentence = "";
    [SerializeField]
    private Text _sentenceText;
    [Header("����")]
    [SerializeField]
    private string _date = "20XX/XX/XX";
    [SerializeField]
    private Text _dateText;
    [Header("�����j���ǂ���")]
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
    /// �{�^���ŌĂяo��
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

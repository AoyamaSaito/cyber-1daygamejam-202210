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
    [Header("�����j���ǂ���")]
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
    /// �{�^���ŌĂяo��
    /// </summary>
    public void DarkCheck()
    {
        if(_isDark == true)
        {
            //GameManager�Ƃ��ɒl������
        }
        else
        {

        }
    }
}

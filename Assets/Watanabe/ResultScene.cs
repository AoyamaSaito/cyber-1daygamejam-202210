using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary> ���U���g�V�[���̃^�C���\�� </summary>
public class ResultScene : MonoBehaviour
{
    [SerializeField] Text _scoreTime;
 
    // Start is called before the first frame update
    void Start()
    {
        _scoreTime.text = $"{GameManager.Timer:F1} �b�ō����j������������";
    }
}

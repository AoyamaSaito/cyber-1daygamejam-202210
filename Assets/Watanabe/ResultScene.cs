using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary> リザルトシーンのタイム表示 </summary>
public class ResultScene : MonoBehaviour
{
    [SerializeField] Text _scoreTime;
 
    // Start is called before the first frame update
    void Start()
    {
        _scoreTime.text = $"{GameManager.Timer:F1} 秒で黒歴史を消し去った";
    }
}

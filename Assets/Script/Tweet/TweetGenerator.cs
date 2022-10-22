using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class TweetGenerator : MonoBehaviour
{
    [SerializeField]
    private int _normal = 10;
    [SerializeField]
    private List<GameObject> _normalTweets = new List<GameObject>();
    [SerializeField]
    private int _dark = 4;
    [SerializeField]
    private List<GameObject> _darkTweets = new List<GameObject>();
    [SerializeField]
    private Transform _content;

    private List<GameObject> _shuffleNormalTweets = new List<GameObject>();
    private List<GameObject> _shuffleDarkTweets = new List<GameObject>();
    private List<GameObject> _currentTweets = new List<GameObject>();

    private void Start()
    {
        Init();
    }

    public void Init()
    {
        if(_currentTweets != null)
        {
            _currentTweets.ForEach(go => Destroy(go));
        }

        _shuffleNormalTweets = ShuffleListGenerate(_normalTweets, _normal);
        _shuffleDarkTweets = ShuffleListGenerate(_darkTweets, _dark);

        _shuffleNormalTweets.AddRange(_shuffleDarkTweets);
        _currentTweets = ShuffleListGenerate(_shuffleNormalTweets);

        _currentTweets = TweetInstantiate(_currentTweets);
    }

    private List<GameObject> ShuffleListGenerate(List<GameObject> list, int count = 0)
    {
        List<GameObject> result = new List<GameObject>();
        list = list.OrderBy(i => Guid.NewGuid()).ToList();

        if (count != 0)
        {
            for (int i = 0; i < count; i++)
            {
                result.Add(list[i]);
            }
        }
        else
        {
            result = list;
        }

        return result;
    }

    private List<GameObject> TweetInstantiate(List<GameObject> list)
    {
        if (_content == null) return null;

        List<GameObject> result = new List<GameObject>();

        for (int i = 0; i < list.Count; i++)
        {
            result.Add(Instantiate(list[i], _content));
        }

        RectTransform rec = _content.GetComponent<RectTransform>();
        Vector2 siz = rec.sizeDelta;
        siz.y = list.Count * 150;
        rec.sizeDelta = siz;

        return result;
    }

    public int Normal => _normal;
    public int Dark => _dark;
}

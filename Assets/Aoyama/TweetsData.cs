using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TweetsData
{
    [SerializeField]
    private int _normal = 10;
    [SerializeField]
    private List<GameObject> _normalTweets = new List<GameObject>();
    [SerializeField]
    private int _dark = 4;
    [SerializeField]
    private List<GameObject> _darkTweets = new List<GameObject>();

    public int Normal => _normal;
    public int Dark => _dark;
}




using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    /// <summary> �N���A��ʂɑJ��(�Ńc�C�[�g0�ŌĂяo��) </summary>
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}

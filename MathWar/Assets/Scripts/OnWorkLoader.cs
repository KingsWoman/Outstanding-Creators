using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OnWorkLoader : MonoBehaviour
{
    public Button Back;

    void Start()
    {
        Back.onClick.AddListener(() => SceneManager.LoadScene(User.sceneHistory.Pop()));
    }
}

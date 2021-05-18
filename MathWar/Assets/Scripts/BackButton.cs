using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    public void Awake()
    {
        GetComponent<Button>().onClick.AddListener(() => SceneManager.LoadScene(User.sceneHistory.Pop()));
    }
}

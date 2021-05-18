using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Scene = UnityEditor.SearchService.Scene;

public class MainMenuLoader : MonoBehaviour
{
    public Button ExitButton;
    public Button RatingButton;
    public Button AccountButton;
    public Button MusicButton;
    public Button ShopButton;
    public Button PlayButton;

    void Awake()
    {
        ExitButton.onClick.AddListener(Application.Quit);
        MusicButton.onClick.AddListener(() => User.IsMusicOn = !User.IsMusicOn);
        RatingButton.onClick.AddListener(() => LoadNewScene("OnWork"));
        AccountButton.onClick.AddListener(() => LoadNewScene("OnWork"));
        ShopButton.onClick.AddListener(() => LoadNewScene("OnWork"));
        PlayButton.onClick.AddListener(() => LoadNewScene("ThemeChoose"));
    }

    private static void LoadNewScene(string scene)
    {
        User.sceneHistory.Push(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(scene);
    }
}
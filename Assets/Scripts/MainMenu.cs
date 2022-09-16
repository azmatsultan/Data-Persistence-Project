using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainMenu : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    public TMP_InputField playerNameInputField;

    private void Start()
    {
        highScoreText.SetText("High Score : " + GameManager.Instance.playerName + " : " + GameManager.Instance.highscore.ToString() + " pts");
        playerNameInputField.text = GameManager.Instance.playerName;
    }

    public void StartNew()
    {
        GameManager.Instance.playerName = playerNameInputField.text;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        GameManager.Instance.SaveHighScore();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

}

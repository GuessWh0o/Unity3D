using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("1");
    }

    public void Upgrades()
    {
        SceneManager.LoadScene("CharacterSelection");
    }

    public void Options()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
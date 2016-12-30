using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private int score;
    public GUIText scoreText;
    public GUIText restartText;
    public GUIText gameOverText;
    public GUIText globalScore;

    public bool gameOver;

	public int Score
	{
	    get { return score;}

        set { score = value; }
	}
   // public Texture[] spaceTextures;
  //  public int currentTexture;
    //GameObject spaceBackground;

    void Start()
    {
      //  spaceBackground = GameObject.FindWithTag("Background");
        gameOver = false;
        restartText.text = "";
        gameOverText.text = "";
        score = 0;
    }


    void Update()
    {
        if (gameOver)  //restart game
        {
            restartText.text = "Double tap to restart";
            gameOverText.text = "Game Over";

            for (int i = 0; i < Input.touchCount; ++i)
            {
                if (Input.GetTouch(i).phase == TouchPhase.Began)
                {
                    if (Input.GetTouch(i).tapCount == 2)
                    {
                        SceneManager.LoadScene(1);
                    }
                }
            }
        }
    }
    public void AddScore()
    {
        score++;
        scoreText.text = "Score: " + score;
        //CheckForScore(score);
    }
    public void GameOver()
    {
        PlayerPrefs.SetInt("GlobalScore", score);
        gameOverText.text = "Game Over";
        gameOver = true;
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    //public void CheckForScore(int scoreShit)
    //{
    //    switch (score)
    //    {
    //        case 10:
    //            TextureChange(1);
    //            break;
    //        case 50:
    //            TextureChange(2);
    //            break;
    //        case 100:
    //            TextureChange(0);
    //            break;
    //        case 150:
    //            SceneManager.LoadScene(1);
    //            break;
    //    } 
    //}
    //public void TextureChange(int textnum)
    //{
    //    currentTexture++;
    //    currentTexture %= spaceTextures.Length;
    //    spaceBackground.GetComponent<Renderer>().material.mainTexture = spaceTextures[textnum];
    //}
}

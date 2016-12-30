using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    public int lives = 3;
    public int bricks = 20;
    public float resetDelay = 1.0f;
    public Text LivesText;
    public GameObject gameOver;
    public GameObject youWon;
    public GameObject bricksPrefab;
    public GameObject paddle;
    public GameObject deathParticles;
    public static GM instance = null;
    private GameObject clonePaddle;

    public GameObject[] cookies;

    public bool isPlaying;


    // Use this for initialization

    void Awake()
	{
		if(instance == null)
			instance = this;
		else if(instance != this)
			Destroy(gameObject);
		Setup();
        StartCoroutine("CookiesFly");
	}

	public void Setup()
	{
        isPlaying = true;
        Vector3 brickPosition = new Vector3(11.4f, 4.0f, 20.0f);
		clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
		Instantiate(bricksPrefab, brickPosition, Quaternion.identity);
        
        StartCoroutine("CookiesFly");
    }

    IEnumerator CookiesFly()
    {
        while(isPlaying)
        {
            int i = Random.Range(0, 2);
            yield return new WaitForSeconds(Random.Range(3.0f, 9.0f));
            Instantiate(cookies[i]);
        }
        
    }

    void CheckGameOver()
    {
        if (bricks < 1)
        {
            youWon.SetActive(true);
            Time.timeScale = .25f;
            Invoke ("Reset", resetDelay);
			//Application.LoadLevel ("Level 2");
        }

        if (lives < 1)
        {
            isPlaying = false;
            gameOver.SetActive(true);
            Time.timeScale = .25f;
            Invoke("Reset", resetDelay);
        }

    }


    void Reset()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("Main");
		//Application.LoadLevel(Application.loadedLevel);
    }

    public void LoseLife()
    {
        lives--;
        LivesText.text = "Lives:" + lives;
        Instantiate(deathParticles, clonePaddle.transform.position, Quaternion.identity);
        Destroy(clonePaddle);
        Invoke("SetupPaddle", resetDelay);
        CheckGameOver();
    }

	void SetupPaddle()
	{
		clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
	}

    public void DestroyBrick()
    {
        bricks--;
        CheckGameOver();
    }
}

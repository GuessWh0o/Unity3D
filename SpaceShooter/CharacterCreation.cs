using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CharacterCreation : MonoBehaviour
{
    private GameObject[] characterList;
    private int index;

    private void Start()
    {
        characterList = new GameObject[transform.childCount];

        //fill array with the models
        for (int i = 0; i < transform.childCount; i++)
        {
            characterList[i] = transform.GetChild(i).gameObject;
        }

        foreach (GameObject go in characterList)
        {
            go.SetActive(false);
        }
        if (characterList[0])
            characterList[0].SetActive(true);
    }

    public void ToggleLeft()
    {
        characterList[index].SetActive(false);

        index--;
        if (index < 0)
        {
            index = characterList.Length - 1;
        }

        characterList[index].SetActive(true);
    }

    public void ToggleRight()
    {
        characterList[index].SetActive(false);

        index++;
        if (index == characterList.Length)
        {
            index = 0;
        }

        characterList[index].SetActive(true);
    }

    public void ConfirmButton()
    {
        PlayerPrefs.SetInt("CharacterSelected", index);
      //  SceneManager.LoadScene("Menu");
    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }
}

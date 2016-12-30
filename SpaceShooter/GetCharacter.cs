using UnityEngine;
using System.Collections;

public class GetCharacter : MonoBehaviour
{
    private GameObject[] characterList;
    private int index;
    private int score;

    // Use this for initialization
    void Awake()
    {
        score = PlayerPrefs.GetInt("GlobalScore");
        index = PlayerPrefs.GetInt("CharacterSelected");

        characterList = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
        {
            characterList[i] = transform.GetChild(i).gameObject;
        }

        foreach (GameObject go in characterList)
        {
            go.SetActive(false); 
        }
        if (characterList[index])
            characterList[index].SetActive(true);

    }
}

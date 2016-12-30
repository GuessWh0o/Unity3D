using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Heart : MonoBehaviour
{

    private GameObject player;

    //Healtheclaring
    public Sprite[] HeartSprite;
    public Image HeartUI;


    //ManaDeclaring
    public Sprite[] ManaSprite;
    public Image ManaUI;



    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        HeartUI.sprite = HeartSprite[player.GetComponent<HealthSystem>().currHealth];

        ManaUI.sprite = ManaSprite[player.GetComponent<HealthSystem>().currentMana];
    }
}

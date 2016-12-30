using UnityEngine;
using System.Collections;

public class GUI_Persss : MonoBehaviour 
{
    public float f;
    public bool g = false;

    public Texture2D textur_1;
    public Texture2D textur_2;

	// Update is called once per frame
	void Update () 
    {
	
	}
    void OnGUI()
    {
        if(g == false)
        {
            GUI.DrawTexture(new Rect(Screen.width - 648/2, (Screen.height - 55), 280, 48), textur_1);   
        }
       else GUI.DrawTexture(new Rect(Screen.width - 648/2, (Screen.height - 55), 280, 48), textur_2); 
  

        if(Input.GetKeyDown(KeyCode.Alpha1))  
        {
            g = true;
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            g = false;
        }
    }
}

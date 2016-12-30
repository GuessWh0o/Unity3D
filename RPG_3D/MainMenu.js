

var quit=false;

function OnMouseEnter()
{
	GetComponent.<Renderer>().material.color = Color.red;
}

function OnMouseExit()
{
	GetComponent.<Renderer>().material.color = Color.white;
}

function OnMouseUp()
{
	if(quit == true)
	{
		Application.Quit();
	}
	else
	{
		Application.LoadLevel("MainScene");
	}
}
function Update()
{
	if(Input.GetKey(KeyCode.Escape))
	{
		Application.Quit();
	}
}
//Variables for our Top Banner in the Main Menu
var topBannerH : float;
var topBannerW : float;

//Variables for our Buttons in the Main Menu
var buttonSizeH : float;
var buttonSizeW : float;
var buttonPos1 : float;
var buttonPos2 : float;
var buttonPos3 : float;
var buttonPos4 : float;
var buttonPos5 : float;

//Variables for our Bottom Banner in the Main Menu
var bottomBannerH : float;
var bottomBannerW : float;
var bottomBannerPos : float;
var customSkin1 : GUISkin;
var customSkin2 : GUISkin;
var customSkin3 : GUISkin;

//The Awake function for our Main menu
function Awake ()
{
	topBannerH = Screen.height/4;
	topBannerW = Screen.width;
	buttonSizeH = Screen.height/10;
	buttonSizeW = Screen.width;
	buttonPos1 = topBannerH;
	buttonPos2 = topBannerH+buttonSizeH;
	buttonPos3 = topBannerH+buttonSizeH*2;
	buttonPos4 = topBannerH+buttonSizeH*3;
	buttonPos5 = topBannerH+buttonSizeH*4;
	bottomBannerH = Screen.height/4;
	bottomBannerW =  Screen.width;
	bottomBannerPos = topBannerH+buttonSizeH*5;	
}

function OnGUI() 
{
	// Custom GUI Skin 1
	GUI.skin = customSkin1;
	
	//Title Banner Text Field
	GUI.Box(Rect(0,0,topBannerW,topBannerH),"STAR LEAGUE");
	
	// Custom GUI Skin 2
	GUI.skin = customSkin2;
	
	//Button 1
	if (GUI.Button(Rect(0,buttonPos1,buttonSizeW,buttonSizeH),"PLAY NOW"))
	{
		Application.LoadLevel(1);
	}
	
	//Button 2
	if (GUI.Button(Rect(0,buttonPos2,buttonSizeW,buttonSizeH),"HOW TO PLAY"))
	{
		Application.LoadLevel(2);	
	}
	
	//Button 3
	if (GUI.Button(Rect(0,buttonPos3,buttonSizeW,buttonSizeH),"HIGHSCORE"))
	{
	
	}
	
	//Button 4
	if (GUI.Button(Rect(0,buttonPos4,buttonSizeW,buttonSizeH),"CREDITS"))
	{
		Application.LoadLevel(3);
	}
	
	//Button 5
	if (GUI.Button(Rect(0,buttonPos5,buttonSizeW,buttonSizeH),"QUIT GAME"))
	{
		Application.Quit();
	}
	
	// Custom GUI Skin 3
	GUI.skin = customSkin3;
	
	//Bottom Banner Text Field
	GUI.Box(Rect(0,bottomBannerPos,bottomBannerW,bottomBannerH),"A PROJECT-X PRODUCTION");
}
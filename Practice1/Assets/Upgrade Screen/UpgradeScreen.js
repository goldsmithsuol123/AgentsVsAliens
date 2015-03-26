
var isQuit=false;
var loadID = 0;

function OnMouseEnter(){
	//change text color
	renderer.material.color=Color.red;
}

function OnMouseExit(){
	//change text color
	renderer.material.color=Color.white;
}

function OnMouseUp(){
	//is this quit
	if (isQuit==true) {
		//quit the game
		Application.Quit();
	}
	else {
		//load level
		Application.LoadLevel(loadID);
	}
}

function Update(){
	//quit game if escape key is pressed
	
}
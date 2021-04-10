using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentTurnScript : MonoBehaviour
{
		Text currentTurnText;
    // Start is called before the first frame update
    void Start()
    {
        GameObject txt = GameObject.Find("CurrentTurnText");
		currentTurnText = txt.GetComponent<Text>();
		currentTurnText.text = "Current Turn: ";
    }	

    // Update is called once per frame
    void Update()
    {
		changeTurnText();
	}
	
	void changeTurnText(){
        if(BattleTurn.currentTurn % 4 == 0){
			currentTurnText.text = "Current Turn: Warrior";

	    }//end if	
		if(BattleTurn.currentTurn % 4 == 1){
			currentTurnText.text = "Current Turn: Mage";

	    }//end if	
		if(BattleTurn.currentTurn % 4 == 2){
			currentTurnText.text = "Current Turn: Enemy 1";

	    }//end if	
		if(BattleTurn.currentTurn % 4 == 3){
			currentTurnText.text = "Current Turn: Enemy 2";

	    }//end if	
    }//end changeTurnText
}

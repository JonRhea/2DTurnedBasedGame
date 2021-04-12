using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class onPotion : MonoBehaviour
{
	
	//Text playerSelectText;
	//Text itemSelectText;
    // Start is called before the first frame update
    void Start()
    {
		//GameObject txt = GameObject.Find("PlayerSelectTextPotion");
		//playerSelectText = txt.GetComponent<Text>();
		
		//GameObject txt2 = GameObject.Find("ItemSelectText");
		//itemSelectText = txt2.GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void onPotionWarrior(){
		
		if(WarriorScript.getCurrentHP() + 50 >= 100){
			WarriorScript.setHP(100);
		}//end if
		else{
			WarriorScript.setHP(WarriorScript.getCurrentHP() + 50);
		}//end else		
		BattleTurn.currentTurn++;
	}//end onPotion
	
	public void onPotionMage(){
		
		if(MageScript.getCurrentHP() + 50 >= 80){
			MageScript.setHP(80);
		}//end if
		else{
			MageScript.setHP(MageScript.getCurrentHP() + 50);
		}//end else
		
		BattleTurn.currentTurn++;
	}//end onPotion
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onElixir : MonoBehaviour
{
    public void onElixirWarrior(){
		
		if(WarriorScript.getCurrentMP() + 10 >= WarriorScript.getMaxMP()){
			WarriorScript.setMP(WarriorScript.getMaxMP());
		}//end if
		else{
			WarriorScript.setMP(WarriorScript.getCurrentMP() + 10);
		}//end else		
		BattleTurn.currentTurn++;
	}//end onElixerWarrior
	
	public void onElixirMage(){
		
		if(MageScript.getCurrentMP() + 10 >= MageScript.getMaxMP()){
			MageScript.setHP(MageScript.getMaxMP());
		}//end if
		else{
			MageScript.setMP(MageScript.getCurrentMP() + 10);
		}//end else
		
		BattleTurn.currentTurn++;
	}//end onElixerMage
}

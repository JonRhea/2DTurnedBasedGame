using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onHeal : MonoBehaviour
{
	public AudioSource errorSound;
	
    public void onHealWarrior(){
		if(BattleTurn.playerCurrentMP >= 6){
			if(BattleTurn.currentTurn % 4 == 0){
				WarriorScript.setHP(WarriorScript.getCurrentHP() + BattleTurn.playerMagicStat + 10);
				WarriorScript.setMP(WarriorScript.getCurrentMP() - 6);
			}//end if
			
			if(BattleTurn.currentTurn % 4 == 1){
				WarriorScript.setHP(WarriorScript.getCurrentHP() + BattleTurn.playerMagicStat + 10);
				MageScript.setMP(MageScript.getCurrentMP() - 6);
			}
			//WarriorScript.setHP(WarriorScript.getCurrentHP() + BattleTurn.playerMagicStat + 10);
			//WarriorScript.setMP(WarriorScript.getCurrentMP() - 6);
			BattleTurn.currentTurn++;
		}
		else if(BattleTurn.playerCurrentMP < 6){
			errorSound.Play();
			
		}//end else if
	}//end onHealWarrior
	
	
	public void onHealMage(){
		if(BattleTurn.playerCurrentMP >= 6){
			if(BattleTurn.currentTurn % 4 == 0){
				MageScript.setHP(MageScript.getCurrentHP() + BattleTurn.playerMagicStat + 10);
				WarriorScript.setMP(WarriorScript.getCurrentMP() - 6);
			}//end if
			
			if(BattleTurn.currentTurn % 4 == 1){
				MageScript.setHP(MageScript.getCurrentHP() + BattleTurn.playerMagicStat + 10);
				MageScript.setMP(MageScript.getCurrentMP() - 6);
			}
		
			BattleTurn.currentTurn++;
		}
		else if(BattleTurn.playerCurrentMP < 6){
			errorSound.Play();
			
		}//end else if
	}//end onHealMage
}

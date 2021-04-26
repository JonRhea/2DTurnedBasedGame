using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onMoreHeal : MonoBehaviour
{
	public AudioSource errorSound;
     public void onMoreHealWarrior(){
		 if(BattleTurn.playerCurrentMP >= 12){
			if(BattleTurn.currentTurn % 4 == 0){
				WarriorScript.setHP(WarriorScript.getCurrentHP() + BattleTurn.playerMagicStat + 20);
				WarriorScript.setMP(WarriorScript.getCurrentMP() - 12);
			}//end if
			
			if(BattleTurn.currentTurn % 4 == 1){
				WarriorScript.setHP(WarriorScript.getCurrentHP() + BattleTurn.playerMagicStat + 20);
				MageScript.setMP(MageScript.getCurrentMP() - 12);
			}
		
			BattleTurn.currentTurn++;
		}
		else if(BattleTurn.playerCurrentMP < 12){
			errorSound.Play();
			
		}//end else if
		
	}//end onMoreHealWarrior
	
	
	public void onMoreHealMage(){
		
		if(BattleTurn.playerCurrentMP >= 12){
			if(BattleTurn.currentTurn % 4 == 0){
				MageScript.setHP(MageScript.getCurrentHP() + BattleTurn.playerMagicStat + 20);
				WarriorScript.setMP(WarriorScript.getCurrentMP() - 12);
			}//end if
			
			if(BattleTurn.currentTurn % 4 == 1){
				MageScript.setHP(MageScript.getCurrentHP() + BattleTurn.playerMagicStat + 20);
				MageScript.setMP(MageScript.getCurrentMP() - 12);
			}
			
			BattleTurn.currentTurn++;
		}
		else if(BattleTurn.playerCurrentMP < 12){
			errorSound.Play();
			
		}//end else if
	
	}//end onMoreHealMage
}

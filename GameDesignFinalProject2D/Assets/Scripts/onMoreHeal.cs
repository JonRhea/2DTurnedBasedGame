using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onMoreHeal : MonoBehaviour
{
     public void onMoreHealWarrior(){
		
		WarriorScript.setHP(WarriorScript.getCurrentHP() + BattleTurn.playerMagicStat + 20);
		BattleTurn.currentTurn++;
	}//end onMoreHealWarrior
	
	
	public void onMoreHealMage(){
		
		MageScript.setHP(MageScript.getCurrentHP() + BattleTurn.playerMagicStat + 20);
		BattleTurn.currentTurn++;
	}//end onMoreHealMage
}

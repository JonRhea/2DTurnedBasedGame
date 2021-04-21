using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onHeal : MonoBehaviour
{
    public void onHealWarrior(){
		
		WarriorScript.setHP(WarriorScript.getCurrentHP() + BattleTurn.playerMagicStat + 10);
		BattleTurn.currentTurn++;
	}//end onHealWarrior
	
	
	public void onHealMage(){
		
		MageScript.setHP(MageScript.getCurrentHP() + BattleTurn.playerMagicStat + 10);
		BattleTurn.currentTurn++;
	}//end onHealMage
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onBomb : MonoBehaviour
{
    public void onBombButton1(){
		EnemyScript.setHP(EnemyScript.getCurrentHP() - 20);
		BattleTurn.currentTurn++;
	}
	
	public void onBombButton2(){
		Enemy2Script.setHP(Enemy2Script.getCurrentHP() - 20);
		BattleTurn.currentTurn++;
	}
}

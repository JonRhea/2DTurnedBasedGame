using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onAttack : MonoBehaviour
{
	
	Text enemySelectText;
	
	void Start()
    {
        GameObject txt = GameObject.Find("EnemySelectTextAttack");
		enemySelectText = txt.GetComponent<Text>();
		
    }	

	public void onAttackButton(){
		int enemyHPcurrent = EnemyScript.getCurrentHP();
		
		//prints are for debugging
		print(enemyHPcurrent);
		print(BattleTurn.playerAttackStat);
		print(EnemyScript.getDefenseStat());
		
	
		EnemyScript.setHP(enemyHPcurrent - BattleTurn.playerAttackStat + EnemyScript.getDefenseStat() - 10);
		
		enemyHPcurrent = EnemyScript.getCurrentHP();
		print(enemyHPcurrent);
		BattleTurn.currentTurn++;
		
		enemySelectText.gameObject.SetActive(false);
	}//end onAttackButton
	
	public void onAttackButton2(){
		int enemy2HPcurrent = Enemy2Script.getCurrentHP();
		
		//prints are for debugging
		print(enemy2HPcurrent);
		print(BattleTurn.playerAttackStat);
		print(Enemy2Script.getDefenseStat());
		
	
		Enemy2Script.setHP(enemy2HPcurrent - BattleTurn.playerAttackStat + Enemy2Script.getDefenseStat() - 10);
		
		enemy2HPcurrent = Enemy2Script.getCurrentHP();
		print(enemy2HPcurrent);
		BattleTurn.currentTurn++;
		
		enemySelectText.gameObject.SetActive(false);
	}//end onAttackButton
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onAttack : MonoBehaviour
{
	
	Text enemySelectText;
	public AudioSource errorSound;
	
	void Start()
    {
        GameObject txt = GameObject.Find("EnemySelectTextAttack");
		enemySelectText = txt.GetComponent<Text>();
		//playerEnd = new Vector3(4f, 2.34f, -3.646777f);
		
    }	
	


	public void onAttackButton(){
		
		if(EnemyScript.getCurrentHP() > 0){
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
		}//end if
		else if(EnemyScript.getCurrentHP() <= 0){
			errorSound.Play();
			print("attack button 1");
		}//end if
	}//end onAttackButton
	
	public void onAttackButton2(){
		
		if(Enemy2Script.getCurrentHP() > 0){
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
		}//end if
		else if(Enemy2Script.getCurrentHP() <= 0){
			errorSound.Play();
			print("attack button 2");
		}//end if
	}//end onAttackButton
	
	
}

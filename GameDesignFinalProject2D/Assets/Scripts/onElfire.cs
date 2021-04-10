using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onElfire : MonoBehaviour
{
	
	Text enemySelectText;
	Text magicSelectText;
	
	void Start()
    {
        GameObject txt = GameObject.Find("EnemySelectTextElfire");
		enemySelectText = txt.GetComponent<Text>();
		
		GameObject txt2 = GameObject.Find("MagicSelectText");
		magicSelectText = txt2.GetComponent<Text>();
	}	
	
	void Update()
	{
		//if(enemySelectText.gameObject.activeInHierarchy == true){
		//	magicSelectText.gameObject.SetActive(false);
		//}//end if 
		
	}
	
    public void onElFireButton(){
	   
	   int enemyHPcurrent = EnemyScript.getCurrentHP();
		
		//prints are for debugging
		print(enemyHPcurrent);
		print(BattleTurn.playerMagicStat);
		print(EnemyScript.getMagicStat());
		
		EnemyScript.setHP(enemyHPcurrent - BattleTurn.playerMagicStat + EnemyScript.getMagicStat() - 15);
		
		enemyHPcurrent = EnemyScript.getCurrentHP();
		print(enemyHPcurrent);
		
		if(BattleTurn.currentTurn % 4 == 0){
			WarriorScript.setMP(WarriorScript.getCurrentMP() - 8);
		}//end if
		
		if(BattleTurn.currentTurn % 4 == 1){
			MageScript.setMP(MageScript.getCurrentMP() - 8);
		}//end if
		
		BattleTurn.currentTurn++;
		
		enemySelectText.gameObject.SetActive(false);
   }//end onElFireButton
   
   public void onElFireButton2(){
	   
	   int enemy2HPcurrent = Enemy2Script.getCurrentHP();
		
		//prints are for debugging
		print(enemy2HPcurrent);
		print(BattleTurn.playerMagicStat);
		print(Enemy2Script.getMagicStat());
		
		Enemy2Script.setHP(enemy2HPcurrent - BattleTurn.playerMagicStat + Enemy2Script.getMagicStat() - 15);
		
		enemy2HPcurrent = Enemy2Script.getCurrentHP();
		print(enemy2HPcurrent);
		
		if(BattleTurn.currentTurn % 4 == 0){
			WarriorScript.setMP(WarriorScript.getCurrentMP() - 8);
		}//end if
		
		if(BattleTurn.currentTurn % 4 == 1){
			MageScript.setMP(MageScript.getCurrentMP() - 8);
		}//end if
		
		BattleTurn.currentTurn++;
		
		enemySelectText.gameObject.SetActive(false);
   }//end onElFireButton2
}

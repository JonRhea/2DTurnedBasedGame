using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onElfire : MonoBehaviour
{
	
	//Text enemySelectText;
	//Text magicSelectText;
	bool didAttack = false;
	
	void Start()
    {
        //GameObject txt = GameObject.Find("EnemySelectTextElfire");
		//enemySelectText = txt.GetComponent<Text>();
		
		//GameObject txt2 = GameObject.Find("MagicSelectText");
		//magicSelectText = txt2.GetComponent<Text>();
	}	
	
	void Update()
	{
		//if(enemySelectText.gameObject.activeInHierarchy == true){
		//	magicSelectText.gameObject.SetActive(false);
		//}//end if 
		
	}
	
    public void onElFireButton(){
	   
	   didAttack = false;
	   if(WarriorScript.getCurrentMP() >= 8 && BattleTurn.currentTurn % 4 == 0 && didAttack == false){
		    didAttack = true;
		    int enemyHPcurrent = EnemyScript.getCurrentHP();
			
			//prints are for debugging
			print(enemyHPcurrent);
			print(BattleTurn.playerMagicStat);
			print(EnemyScript.getMagicStat());
			
			EnemyScript.setHP(enemyHPcurrent - BattleTurn.playerMagicStat + EnemyScript.getMagicStat() - 15);
			
			enemyHPcurrent = EnemyScript.getCurrentHP();
			print(enemyHPcurrent);
			
			WarriorScript.setMP(WarriorScript.getCurrentMP() - 8);
			
			BattleTurn.currentTurn++;
			
			//enemySelectText.gameObject.SetActive(false);
	   }//end if
	   
	   if(MageScript.getCurrentMP() >= 8 && BattleTurn.currentTurn % 4 == 1 && didAttack == false){
		    didAttack = true;
		    int enemyHPcurrent = EnemyScript.getCurrentHP();
			
			//prints are for debugging
			print(enemyHPcurrent);
			print(BattleTurn.playerMagicStat);
			print(EnemyScript.getMagicStat());
			
			EnemyScript.setHP(enemyHPcurrent - BattleTurn.playerMagicStat + EnemyScript.getMagicStat() - 15);
			
			enemyHPcurrent = EnemyScript.getCurrentHP();
			print(enemyHPcurrent);
			
			MageScript.setMP(MageScript.getCurrentMP() - 8);
			
			BattleTurn.currentTurn++;
			
			//enemySelectText.gameObject.SetActive(false);
	   }//end if
   }//end onElFireButton
   
   public void onElFireButton2(){
	   
	    didAttack = false;
	   if(WarriorScript.getCurrentMP() >= 8 && BattleTurn.currentTurn % 4 == 0 && didAttack == false){
			int enemy2HPcurrent = Enemy2Script.getCurrentHP();
			
			//prints are for debugging
			print(enemy2HPcurrent);
			print(BattleTurn.playerMagicStat);
			print(Enemy2Script.getMagicStat());
			
			Enemy2Script.setHP(enemy2HPcurrent - BattleTurn.playerMagicStat + Enemy2Script.getMagicStat() - 15);
			
			enemy2HPcurrent = Enemy2Script.getCurrentHP();
			print(enemy2HPcurrent);
			
			WarriorScript.setMP(WarriorScript.getCurrentMP() - 8);
			
			BattleTurn.currentTurn++;
	   }//end if
	   
	   if(MageScript.getCurrentMP() >= 8 && BattleTurn.currentTurn % 4 == 1 && didAttack == false){
			didAttack = true;
			int enemy2HPcurrent = EnemyScript.getCurrentHP();
			
			//prints are for debugging
			print(enemy2HPcurrent);
			print(BattleTurn.playerMagicStat);
			print(Enemy2Script.getMagicStat());
			
			Enemy2Script.setHP(enemy2HPcurrent - BattleTurn.playerMagicStat + Enemy2Script.getMagicStat() - 15);
			
			enemy2HPcurrent = Enemy2Script.getCurrentHP();
			print(enemy2HPcurrent);
			
			MageScript.setMP(MageScript.getCurrentMP() - 8);
		
			BattleTurn.currentTurn++;
	    }//end if
   }//end onElFireButton2
}

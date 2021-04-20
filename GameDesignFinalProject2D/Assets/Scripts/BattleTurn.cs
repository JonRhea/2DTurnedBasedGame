using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleTurn : MonoBehaviour
{
	
	public static int currentTurn = 0;
	
	public static int playerAttackStat = 0;
	public static int playerDefenseStat = 0;
	public static int playerSpeedStat = 0;
	public static int playerMagicStat = 0;
	public static int playerCurrentHP = 0;
	public static int playerMaxHP = 0;
	public static int playerCurrentMP = 0;
	public static int playerMaxMP = 0;
	
    // Start is called before the first frame update
    void Start()
    {
        getTurn();
    }

    // Update is called once per frame
    void Update()
    {
		getTurn();
		
		if(AttackBoost.boostAppliedWarrior == true && AttackBoost.statRevertedWarrior == false && currentTurn == AttackBoost.boostEndWarrior){
			WarriorScript.setAttackStat(10);
			AttackBoost.statRevertedWarrior = true;
			print("Stat reverted for Warrior");
		}//end if
		
		if(AttackBoost.boostAppliedMage == true && AttackBoost.statRevertedMage == false && currentTurn == AttackBoost.boostEndMage){
			MageScript.setAttackStat(5);
			AttackBoost.statRevertedMage = true;
			print("Stat reverted for Mage");
		}//end if
	
	}
	public void getTurn(){
	//if % = 0, then its Warrior turn	
	if(currentTurn % 4 == 0){
		playerAttackStat = WarriorScript.getAttackStat();
		playerDefenseStat = WarriorScript.getDefenseStat();
		playerSpeedStat = WarriorScript.getSpeedStat();
		playerMagicStat = WarriorScript.getMagicStat();
		playerCurrentHP = WarriorScript.getCurrentHP();
		playerMaxHP = WarriorScript.getMaxHP();
		playerCurrentMP = WarriorScript.getCurrentMP();
		playerMaxMP = WarriorScript.getMaxMP();
	}//end if
	
	//if % = 1, then its Mage turn
	if(currentTurn % 4 == 1){
		playerAttackStat = MageScript.getAttackStat();
		playerDefenseStat = MageScript.getDefenseStat();
		playerSpeedStat = MageScript.getSpeedStat();
		playerMagicStat = MageScript.getMagicStat();
		playerCurrentHP = MageScript.getCurrentHP();
		playerMaxHP = MageScript.getMaxHP();
		playerCurrentMP = MageScript.getCurrentMP();
		playerMaxMP = MageScript.getMaxMP();
	}//end if
	
	//if % = 2, then its Enemy1 turn
	if(currentTurn % 4 == 2){
		int randomTarget;
		randomTarget = Random.Range(1,100);
		print(randomTarget);
		
		if(randomTarget <= 50){
			WarriorScript.setHP(WarriorScript.getCurrentHP() - EnemyScript.getAttackStat() + WarriorScript.getDefenseStat() - 10);
		}//end if
		if(randomTarget > 50){
			MageScript.setHP(MageScript.getCurrentHP() - EnemyScript.getAttackStat() + MageScript.getDefenseStat() - 10);
		}//end if
		currentTurn++;
		print(WarriorScript.getCurrentHP());
	}//end if
	
	//if % = 3, then its Enemy2 turn
	if(currentTurn % 4 == 3){
		int randomTarget;
		randomTarget = Random.Range(1,100);
		print(randomTarget);
		
		if(randomTarget <= 50){
			WarriorScript.setHP(WarriorScript.getCurrentHP() - Enemy2Script.getAttackStat() + WarriorScript.getDefenseStat() -10);
		}//end if
		if(randomTarget > 50){
			MageScript.setHP(MageScript.getCurrentHP() - Enemy2Script.getAttackStat() + MageScript.getDefenseStat() - 10);
		}//end if
		currentTurn++;
		print(MageScript.getCurrentHP());
	}//end if
	 
    }
}

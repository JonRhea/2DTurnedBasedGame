using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBoost : MonoBehaviour
{
	public static int boostEndWarrior = 0;
	public static int boostEndMage = 0;
	public static bool boostAppliedWarrior;
	public static bool boostAppliedMage;
	public static bool statRevertedWarrior;
	public static bool statRevertedMage;
	
	
	void Start()
	{
		boostAppliedWarrior = false;
		boostAppliedMage = false;
		statRevertedWarrior = false;
		statRevertedMage = false;
		
	}
	
	void Update()
	{
		
		
		
	}
	
    public void onWarriorBoost(){
		statRevertedWarrior = false;
		boostEndWarrior = BattleTurn.currentTurn + 5;
		boostAppliedWarrior = true;
		WarriorScript.setAttackStat(WarriorScript.getAttackStat() + 10);
		BattleTurn.currentTurn++;
		print(WarriorScript.getAttackStat());
		
	}//end onWarriorBoost
	
	public void onMageBoost(){
		statRevertedMage = false;
		boostEndMage = BattleTurn.currentTurn + 5;
		boostAppliedMage = true;
		MageScript.setAttackStat(MageScript.getAttackStat() + 10);
		BattleTurn.currentTurn++;
		print(MageScript.getAttackStat());		
		
	}//end onMageBoost
}

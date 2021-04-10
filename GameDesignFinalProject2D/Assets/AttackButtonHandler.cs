using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackButtonHandler : MonoBehaviour
{
    public void onAttack(){
		
		EnemyScript.setHP(WarriorScript.getAttackStat() - EnemyScript.getDefenseStat() + 10);
	}//end onAttack
}

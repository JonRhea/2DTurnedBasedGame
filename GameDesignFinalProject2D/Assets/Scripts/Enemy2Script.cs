using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Script : MonoBehaviour
{
    static int attackStat = 5;
	static int defenseStat = 2;
	static int speedStat = 2;
	static int magicStat = 0;
	static int currentHP = 30;
	static int maxHP = 30;
	
	
	
	public static void setHP(int hp){
		
		currentHP = hp;
	}

	public static int getAttackStat(){
		
		return attackStat;
	}
	
	public static int getDefenseStat(){
		
		return defenseStat;
	}
	
	public static int getSpeedStat(){
		
		return speedStat;
	}
	
	public static int getMagicStat(){
		
		return magicStat;
	}
	
	public static int getCurrentHP(){
		
		return currentHP;
	}
	
	public static int getMaxHP(){
		
		return maxHP;
	}
}

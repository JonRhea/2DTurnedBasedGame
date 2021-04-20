using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorScript : MonoBehaviour
{
	
	static int attackStat = 10;
	static int defenseStat = 5;
	static int speedStat = 5;
	static int magicStat = 2;
	static int currentHP = 100;
	static int maxHP = 100;
	static int currentMP = 10;
	static int maxMP = 10;
	
	public static void setHP(int hp){
		
		currentHP = hp;
	}
	
	public static void setMP(int mp){
		
		currentMP = mp;
	}
	
	public static void setAttackStat(int attack){
		
		attackStat = attack;		
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
	
	public static int getCurrentMP(){
		
		return currentMP;
	}
	
	public static int getMaxMP(){
		
		return maxMP;
	}
}

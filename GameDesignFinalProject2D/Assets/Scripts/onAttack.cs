using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onAttack : MonoBehaviour
{
	
	Text enemySelectText;
	//public GameObject playerObject;
	//Vector3 playerEnd;
	//bool isMoving = false;
	
	void Start()
    {
        GameObject txt = GameObject.Find("EnemySelectTextAttack");
		enemySelectText = txt.GetComponent<Text>();
		//playerEnd = new Vector3(4f, 2.34f, -3.646777f);
		
    }	
	


	public void onAttackButton(){
		int enemyHPcurrent = EnemyScript.getCurrentHP();
		//StartCoroutine(moveToX(playerObject.transform, new Vector3(4f, 2.34f, -3.646777f), 1000f));
		/*playerStart = playerObject.transform.position;
		temp = playerObject.transform.position;
		playerEnd = new Vector3(4f, 2.34f, -3.646777f);
		
		while(playerObject.transform.position.x != 4f){
			
			//temp.x += moveSpeed * Time.deltaTime;
			//playerObject.transform.position = temp;
			//playerObject.transform.position = playerEnd;
			print(playerObject.transform.position.x);
		}//end while

		playerObject.transform.position = playerStart;
		*/
		
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
	
	/*IEnumerator moveToX(Transform fromPosition, Vector3 toPosition, float duration){
			
		if (isMoving){
			yield break;
		}
		isMoving = true;

		float counter = 0;

		Vector3 startPos = fromPosition.position;

		while (counter < duration){
			counter += Time.deltaTime;
			fromPosition.position = Vector3.Lerp(startPos, toPosition, counter / duration);
			//yield return null;
		}

		isMoving = false;

		
	}//end moveToX
	*/
}

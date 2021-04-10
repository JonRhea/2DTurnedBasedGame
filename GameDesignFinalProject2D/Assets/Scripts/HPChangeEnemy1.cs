using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPChangeEnemy1 : MonoBehaviour
{
		public Text enemyHPText;
    // Start is called before the first frame update
    void Start()
    {
        GameObject txt = GameObject.Find("Enemy1HP");
		enemyHPText = txt.GetComponent<Text>();
		enemyHPText.text = "HP: " + EnemyScript.getCurrentHP() + "/" + EnemyScript.getMaxHP();
    }

    // Update is called once per frame
    void Update()
    {
		if(EnemyScript.getCurrentHP() > 0){
			enemyHPText.text = "HP: " + EnemyScript.getCurrentHP() + "/" + EnemyScript.getMaxHP();
		}//end if
		
		if(EnemyScript.getCurrentHP() <= 0){
			enemyHPText.text = "HP: " + "0" + "/" + EnemyScript.getMaxHP();
		}//end if
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPChangeEnemy2 : MonoBehaviour
{
    Text enemy2HPText;
    // Start is called before the first frame update
    void Start()
    {
        GameObject txt = GameObject.Find("Enemy2HP");
		enemy2HPText = txt.GetComponent<Text>();
		enemy2HPText.text = "HP: " + Enemy2Script.getCurrentHP() + "/" + Enemy2Script.getMaxHP();
    }

    // Update is called once per frame
    void Update()
    {
        if(Enemy2Script.getCurrentHP() > 0){
			enemy2HPText.text = "HP: " + Enemy2Script.getCurrentHP() + "/" + Enemy2Script.getMaxHP();
		}//end if
		
		if(Enemy2Script.getCurrentHP() <= 0){
			enemy2HPText.text = "HP: " + "0" + "/" + Enemy2Script.getMaxHP();
		}//end if
    }
}

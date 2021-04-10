using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateSelect : MonoBehaviour
{

	//Test for GitHub push
	Text enemySelectText;
	Text magicSelectText;
    // Start is called before the first frame update
    void Start()
    {
        GameObject txt = GameObject.Find("EnemySelectTextFire");
		enemySelectText = txt.GetComponent<Text>();
		
		GameObject txt2 = GameObject.Find("MagicSelectText");
		magicSelectText = txt2.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void onActivateSelect(){
		
		magicSelectText.gameObject.SetActive(false);
		enemySelectText.gameObject.SetActive(true);
	}//end onActivateSelect
}

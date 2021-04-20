using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WonBattle : MonoBehaviour
{
	
	public GameObject wonText;
	public AudioSource battleTheme;
	public AudioSource victoryTheme;
	bool isOver = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(EnemyScript.getCurrentHP() <= 0 && Enemy2Script.getCurrentHP() <= 0 && isOver == false){
			battleTheme.Stop();
			victoryTheme.Play();
			wonText.SetActive(true);
			isOver = true;

	   }//end if		   
    }
}

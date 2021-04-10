using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MageStatChange : MonoBehaviour
{
	public Text mageStats;
    // Start is called before the first frame update
    void Start()
    {
        GameObject mageStatText = GameObject.Find("MageStatText");
		mageStats = mageStatText.GetComponent<Text>();
		
		mageStats.text = "Mage - HP: " + MageScript.getCurrentHP() + "/" 
		+ MageScript.getMaxHP() + " MP: " + MageScript.getCurrentMP() + "/" + MageScript.getMaxMP();
    }

    // Update is called once per frame
    void Update()
    {
        mageStats.text = "Mage - HP: " + MageScript.getCurrentHP() + "/" 
		+ MageScript.getMaxHP() + " MP: " + MageScript.getCurrentMP() + "/" + MageScript.getMaxMP();
    }
}

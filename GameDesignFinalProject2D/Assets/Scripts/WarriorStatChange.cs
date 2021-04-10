using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WarriorStatChange : MonoBehaviour
{
	public Text warriorStats;
    // Start is called before the first frame update
    void Start()
    {
        GameObject warriorStatText = GameObject.Find("WarriorStatText");
		warriorStats = warriorStatText.GetComponent<Text>();
		warriorStats.text = "Warrior - HP: " + WarriorScript.getCurrentHP() + "/" 
		+ WarriorScript.getMaxHP() + " MP: " + WarriorScript.getCurrentMP() + "/" + WarriorScript.getMaxMP();
    }

    // Update is called once per frame
    void Update()
    {
        warriorStats.text = "Warrior - HP: " + WarriorScript.getCurrentHP() + "/" 
		+ WarriorScript.getMaxHP() + " MP: " + WarriorScript.getCurrentMP() + "/" + WarriorScript.getMaxMP();
    }
}

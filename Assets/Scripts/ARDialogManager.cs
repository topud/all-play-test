using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARDialogManager : MonoBehaviour
{
    public Dictionary<string, GameObject> dictDialogs = new Dictionary<string, GameObject>();
    public string dialogTag = "DialoguePrefab";
    
    private void Start()
    {
        
        //dictDialogs.Add(test1.name, test1);
        for (int i = 0; i < transform.GetChild(0).childCount; i++)
        {
            Transform child = transform.GetChild(0).GetChild(i);
            if (child.tag == dialogTag)
            {
                dictDialogs.Add(child.name, child.gameObject);
                //Debug.Log("adding " + child.name);
            }
          
        }
        hideAllDialogs();

    }


    //Accepts a string as dialog and makes it visible
    public void showDialog(string dialogName)
    {
        hideAllDialogs();
        if (dictDialogs.Count > 0)
            dictDialogs[dialogName].SetActive(true);
    }

    //Hides all dialogs shown.
    public void hideAllDialogs()
    {
        foreach (var gameo in dictDialogs.Values)
            gameo.SetActive(false);
    }
}

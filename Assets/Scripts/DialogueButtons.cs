using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueButtons : MonoBehaviour
{
    // Start is called before the first frame update
    List<Component> contentSection;
    void Start()
    {
        // gather all children of the button's parent i.e. siblings
        Component[] items = gameObject.transform.parent.GetComponentsInChildren<Transform>();
        // filter siblings to only text to display into List
        foreach (Component item in items) {
           if(item.tag == "DialogeText") {
               contentSection.Add(item);
               Debug.LogFormat("Added", item);
           }
           
        }

    }

    // Update is called once per frame
    void Update()
    {
    }
}

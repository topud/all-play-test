using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueButtons : MonoBehaviour
{
    // Start is called before the first frame update
    List<Component> contentSection = new List<Component>();
    void Start()
    {
        // gather all children of the button's parent i.e. siblings
        Component[] items = gameObject.transform.parent.GetComponentsInChildren<RectTransform>();

        foreach(Component item in items) {
            Debug.LogFormat("I AM TYPE:  {0}", item.GetType());
            contentSection.Add(item);
        }
        foreach(Component item in contentSection) {
            Debug.LogFormat("Some items that are in the list: {0}", item);
        }
        // filter siblings to only text to display into List
        // foreach (Component item in items) {
        //    if(item.tag == "DialogueText") {
        //        contentSection.Add(item);
        //        Debug.LogFormat("Added", item);
        //    } else {
        //        Debug.LogFormat("NOT ADDED!!!!!!!!");
        //        Debug.LogFormat(item.tag);
        //    }
        // }

    }

    // Update is called once per frame
    void Update()
    {
    }
}

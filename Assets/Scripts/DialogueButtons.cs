using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueButtons : MonoBehaviour
{
    private int diagPointer = 0; 
    // Start is called before the first frame update
    List<Component> contentSection = new List<Component>();
    void Start()
    {
        // gather all children of the button's parent i.e. siblings
        Component[] items = gameObject.transform.GetComponentsInChildren<RectTransform>();

        foreach(Component item in items) {     
            if(item.tag == "DialogueText"){
                contentSection.Add(item);
                item.gameObject.SetActive(false);
            }
        }
        // making first item in list viewable
        contentSection[0].gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void navigateForward() {
        contentSection[diagPointer].gameObject.SetActive(false);
        if(contentSection.Count - 1 == diagPointer) {
            diagPointer = 0;
        } else {
            diagPointer++;
        }
        contentSection[diagPointer].gameObject.SetActive(true);
    }

    public void navigateBackward() {
        contentSection[diagPointer].gameObject.SetActive(false);
        if(diagPointer == 0) {
            diagPointer = contentSection.Count - 1;
        } else {
            diagPointer--;
        }
        contentSection[diagPointer].gameObject.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextButton : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform parentDialogue;
    public GameObject dialogue;
    public void next() {
        dialogue.GetComponent<DialogueButtons>().navigateForward();
    }
}

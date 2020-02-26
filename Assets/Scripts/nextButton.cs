using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextButton : MonoBehaviour
{
    public GameObject dialogue;
    public void next() {
        dialogue.GetComponent<DialogueButtons>().navigateForward();
    }
}

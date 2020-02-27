using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastButton : MonoBehaviour
{
     public GameObject dialogue;

     public void last() {
         dialogue.GetComponent<DialogueContainer>().navigateBackward();
     }
}

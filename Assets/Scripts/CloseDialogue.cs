using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDialogue : MonoBehaviour
{
    public GameObject modalDialogue;
    public void close() {
        modalDialogue.SetActive(false);
    }
}

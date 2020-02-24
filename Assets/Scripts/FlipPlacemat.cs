using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FlipPlacemat : MonoBehaviour
{
    //flag used to track placemat side shown;
    private bool ShowSideA = true;
    
    
    public void flip()
    {
        //Alternate between Side A and Side B and play the respective animation clip by using a trigger
        if (ShowSideA)
            GetComponent<Animator>().SetTrigger("ShowSideB");
        else
            GetComponent<Animator>().SetTrigger("ShowSideA");

        ShowSideA = !ShowSideA;
    }
}

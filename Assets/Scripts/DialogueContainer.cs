﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueContainer : MonoBehaviour
{
    private int diagPointer = 0; 
    private int totalPages;
    private int currPage;
    private TMPro.TextMeshProUGUI pageNum;
    // Start is called before the first frame update
    List<Component> contentSection = new List<Component>();
    void Start()
    {
        // gather all children of the button's parent i.e. siblings
        Component[] items = gameObject.transform.GetComponentsInChildren<RectTransform>();

        foreach(Component item in items)
        {     
            if(item.tag == "DialogueText")
            {
                contentSection.Add(item);
                item.gameObject.SetActive(false);
            }
        }
        // making first item in list viewable
        contentSection[0].gameObject.SetActive(true);

        // Render proper page number indicators at start
        totalPages = contentSection.Count;
        currPage = diagPointer + 1;
        pageNum = gameObject.transform.Find("pageNum").GetComponent<RectTransform>().GetComponent<TMPro.TextMeshProUGUI>();
        pageNum.text = $"{currPage}/{totalPages}";
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void navigateForward()
    {
        contentSection[diagPointer].gameObject.SetActive(false);
        if(contentSection.Count - 1 == diagPointer)
        {
            diagPointer = 0;
        } else {
            diagPointer++;
        }
        currPage = diagPointer + 1; 
        pageNum.text = $"{currPage}/{totalPages}";
        contentSection[diagPointer].gameObject.SetActive(true);
    }

    public void navigateBackward()
    {
        contentSection[diagPointer].gameObject.SetActive(false);
        if(diagPointer == 0)
        {
            diagPointer = contentSection.Count - 1;
        } else {
            diagPointer--;
        }
        currPage = diagPointer + 1; 
        pageNum.text = $"{currPage}/{totalPages}";
        contentSection[diagPointer].gameObject.SetActive(true);
    }
}

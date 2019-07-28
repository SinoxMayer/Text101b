﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

     

    State state;

    // Start is called before the first frame update
    void Start()
    { 
        state = startingState;
        textComponent.text = state.GetStateStory();
    }



    // Update is called once per frame
    void Update()
    {
        ManageState();

    }

    private void ManageState()
    {
        var nextStates = state.GetArrayState();
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            if (nextStates[0] != null)
            {
                state = nextStates[0];
            }

        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (nextStates[1] != null)
            {
                state = nextStates[1 ];
            }

        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if(nextStates[2] != null )
            {
                state = nextStates[2];
            }
           
             

        }
        textComponent.text = state.GetStateStory();
    }
}

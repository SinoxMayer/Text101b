using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(10, 14)] [SerializeField] string storyText;
    [SerializeField] State[] arrayState;


    public State[] GetArrayState()
    {

        return arrayState;
    }

    public string GetStateStory()
    {
        return storyText;
    }
}

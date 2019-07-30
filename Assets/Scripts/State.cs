using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{   /*bu alanda Stateler içinde text girmelik bir alan oluşturyoruz bu alan serializefield ile geliyor */
    [TextArea(10, 14)] [SerializeField] string storyText;
    /*State array oluşturuyor ve bunu serializefield ile ekrana cıkarıyor */
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

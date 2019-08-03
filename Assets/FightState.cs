using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "FightState")]
public class FightState : ScriptableObject

{

    [TextArea(1, 1)] [SerializeField] string hpOfMonster;
    [TextArea(1, 1)] [SerializeField] string dpsOfMonster;
    [TextArea(1, 1)] [SerializeField] string armorOfMonster;

    public string   GetStateFight()
    {

        return hpOfMonster ;
    }
}

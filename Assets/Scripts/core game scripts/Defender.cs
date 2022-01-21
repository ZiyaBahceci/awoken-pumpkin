using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int wheatCost = 100;


    public void AddWheats(int amount)
    {
        FindObjectOfType<wheatDisplay>().AddWheats(amount);
    }
    public int GetwheatCost()
    {
        return wheatCost;
    }

}

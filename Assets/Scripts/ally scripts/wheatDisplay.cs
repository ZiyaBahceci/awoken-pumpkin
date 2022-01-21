using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wheatDisplay : MonoBehaviour
{
     [SerializeField] int wheats = 100;
    Text WheatText;

    void Start()
    {
        WheatText = GetComponent<Text>();
        UpdateDisplay();
    }
    private void UpdateDisplay()
    {
        WheatText.text =  "Wheats : " +wheats.ToString() ;
    }

    public bool HaveEnoughWheats(int amount)
    {
        return wheats >= amount;
    }
    public void AddWheats(int amount)
    {
        wheats += amount;
        UpdateDisplay();
    }
    public void RemoveWheat(int amount)
    {
        if (wheats >= amount)
        {
            wheats -= amount;
            UpdateDisplay();
        }
       
    }
}

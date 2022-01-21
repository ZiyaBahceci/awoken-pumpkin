using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Lives : MonoBehaviour
{
    [SerializeField] float baseLives = 3f;
    [SerializeField] int damage = 1;
    float lives;
    Text livesText;

    void Start()
    {
        
        
    }

    private void UpdateDisplay()
    {
        livesText.text = "Lives : " + lives.ToString();
    }

    public void TakeLife()
    {
        lives -=damage;
        UpdateDisplay();

        if(lives<= 0)
        {
            
            FindObjectOfType<LevelController>().HandleLooseCondition();

        }
        }


    // Update is called once per frame
    void Update()
    {
        lives = baseLives - PlayerPrefsControler.GetDifficulty();
        livesText = GetComponent<Text>();
        UpdateDisplay();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerMage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D othercollider)
    {
        GameObject otherobject = othercollider.gameObject;
        if(otherobject.GetComponent<Attacker>() )
        {
            GetComponent<Animator>().SetBool("isAttacking",true);


        }
    }
}

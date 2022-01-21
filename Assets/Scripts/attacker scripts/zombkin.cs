using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombkin : MonoBehaviour
{
 private void OnTriggerEnter2D(Collider2D other) {
        if(other.GetComponent<Defender>()){
           GetComponent<Attacker>().Attack(other.gameObject);
           GetComponent<Attacker>().SetMovementSpeed(0f);
           Debug.Log(gameObject.name + "hit something");

        }
    }
}

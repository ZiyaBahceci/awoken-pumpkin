using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hound : MonoBehaviour
{
     [SerializeField]float movementspeed;
 private void OnTriggerEnter2D(Collider2D other) {
        if(other.GetComponent<Defender>()){
           GetComponent<Attacker>().Attack(other.gameObject);
           GetComponent<Attacker>().SetMovementSpeed(0f);
           Debug.Log(gameObject.name + "hit something");

        }
    }
    public void normalState(float movementspeed){
        GetComponent<Attacker>().SetMovementSpeed(movementspeed);
    }
}

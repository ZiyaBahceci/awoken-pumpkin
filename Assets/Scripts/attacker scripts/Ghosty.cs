using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghosty : MonoBehaviour
{
    int damage = 30;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.GetComponent<Defender>()){
           GetComponent<Attacker>().Attack(other.gameObject);

        }
    }
}

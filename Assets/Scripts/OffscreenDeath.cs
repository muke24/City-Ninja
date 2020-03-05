using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffscreenDeath : MonoBehaviour
{
    public int damage = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.GetComponent<CharacterMovement>().health -= damage;
        }
    }


}

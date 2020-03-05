using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUp : MonoBehaviour
{
    public int heal = 1;
    public float speed;
    public bool healthCap;

   

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime); //obstacles move direction

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) //if the obstacle collides with a "Player" tag then deal damage and destroy self
        {
            collision.GetComponent<CharacterMovement>().health += heal;
            Destroy(gameObject);
        }
    }

    
}

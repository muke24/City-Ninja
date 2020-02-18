using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int damage = 1;
    public float speed;

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime); //obstacles move direction
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")) //if the obstacle collides with a "Player" tag then deal damage and destroy self
        {
            collision.GetComponent<CharacterMovement>().health -= damage;
            Debug.Log(collision.GetComponent<CharacterMovement>().health);
            Destroy(gameObject);
        }
    }
}

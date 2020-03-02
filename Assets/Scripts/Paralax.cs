using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    public float moveSpeed;
    public float endPosX;
    public float startPosX;

    private void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        if (transform.position.x <= endPosX)
        {
            Vector2 pos = new Vector2(startPosX, transform.position.y);
            transform.position = pos;
        }
    }
}

using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float moveSpeed = 5f;
    Rigidbody2D rb;

    public CharacterStates characterStates;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;

    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && characterStates == CharacterStates.OnGround)
        {
            rb.AddForce(new Vector2(0f, 4f), ForceMode2D.Impulse);
            characterStates = CharacterStates.Jumping;
        }
    }
}

public enum CharacterStates
{
    OnGround,
    Jumping,
    DoubleJumping
}

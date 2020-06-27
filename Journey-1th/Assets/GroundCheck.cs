using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public Character character;  

    private void OnCollisionEnter2D(Collision2D collision) //Quando entra
    {
        if (collision.collider.tag == "Ground")
        {
            character.characterStates = CharacterStates.OnGround; // Se o personagem ta em contato com o chão ele chama o script Character.
        }
    }
    private void OnCollisionExit2D(Collision2D collision) // Quando sai da colisão
    {
        if (collision.collider.tag == "Ground")
        {
         //   character.characterStates = CharacterStates.Jumping;
        }
    }
}

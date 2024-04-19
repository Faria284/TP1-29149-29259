using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundScript : MonoBehaviour
{
    public float impulseScale = 0.5f;

    private void OnCollisionEnter(Collision collision)
    {
        // Verifica se a colisão envolve a bola
        if (collision.gameObject.CompareTag("Ball"))
        {
            // Obtém o Rigidbody da bola
            Rigidbody ballRigidbody = collision.gameObject.GetComponent<Rigidbody>();

            // Verifica se o Rigidbody foi encontrado
            if (ballRigidbody != null)
            {
                // Calcula a direção do impulso (direção oposta ao vetor de normal da colisão)
                Vector3 direction = -collision.contacts[0].normal;

                // Calcula a força do impulso
                float impulseForce = collision.relativeVelocity.magnitude * impulseScale;

                // Aplica o impulso à bola
                ballRigidbody.AddForce(direction * impulseForce, ForceMode.Impulse);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperScript : MonoBehaviour
{

    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float hitStrenght = 10000f;
    public float flipperDamper = 100f;
    HingeJoint hinge;

    public string inputName;

    public AudioSource flipperAudio;
    
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }

    
    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrenght;
        spring.damper = flipperDamper;

        // Quando é selecionado o botão definido no inputName, o flipper realiza o seu movimento e
        // é ativado o som definido
        if (Input.GetAxis(inputName) == 1)
        {
            spring.targetPosition = pressedPosition;
            flipperAudio.Play();
        } 
        // Caso o botão não esteja a ser pressionado, o flipper retorna à sua posição inicial   
        else
        {
            spring.targetPosition = restPosition;
        }
        hinge.spring = spring;
        hinge.useLimits = true;
    }
}

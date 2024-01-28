using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerControl : MonoBehaviour
{
    
    // Rigidbody of the player.
    private Rigidbody rb; 

    private float movementX;
    private float movementY;

    public float speed = 0;

    public TextMeshProUGUI text;
    private int score = 0;
    public GameObject panel;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
 
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x; 
        movementY = movementVector.y; 
    }

    private void FixedUpdate()
    {
        if (score == 8) return;
        Vector3 movement = new Vector3 (movementX, 0.0f, movementY);
        rb.AddForce(movement * speed); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            score++;

            text.text = "Score : " + score;
            
            if (score == 8)
                panel.SetActive(true);
        }
    }
}

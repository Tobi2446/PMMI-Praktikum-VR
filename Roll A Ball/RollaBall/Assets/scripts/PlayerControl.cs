using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody rb;
    public Text punkte;
    public float speed;
    public bool keyboard; 
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
  
    }

    void FixedUpdate () {
    if(keyboard == true){
      float moveHorizontal = Input.GetAxis ("Horizontal"); 
      float moveVertical = Input.GetAxis ("Vertical");
      Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
      rb.AddForce(movement * speed);
    }
    }

    void OnTriggerEnter(Collider other) { 
        if (other.gameObject.CompareTag ("Pick Up")) { 
            other.gameObject.SetActive (false);
            score += 1;
            punkte.text = "Score: " + score;
             } 
            }
}

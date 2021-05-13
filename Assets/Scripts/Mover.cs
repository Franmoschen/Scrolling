using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private Rigidbody2D rb2D;
    public float speed;
    // Start is called before the first frame update
    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        rb2D.velocity = transform.up *speed;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

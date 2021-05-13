using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour

{
    public float FireRate;
    public float NextFire;
    public float speed;
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;
    private Rigidbody2D rb;
    public GameObject shot;
    public Transform shotSpawn;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 Movement = new Vector2(moveHorizontal*speed,moveVertical*speed);
        rb.velocity = Movement;
        rb.position = new Vector2(Mathf.Clamp(rb.position.x, xMin, xMax), Mathf.Clamp(rb.position.y, yMin, yMax));
       
    }
    private void Update()
    {
        if (Input.GetButton("Fire1")&&( Time.time>NextFire))

        {
            NextFire = Time.time + FireRate;
            Instantiate(shot, shotSpawn.position,shotSpawn.rotation);
        }
      
    }
}

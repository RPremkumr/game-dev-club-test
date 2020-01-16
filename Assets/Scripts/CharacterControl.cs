using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{

    public float speed = 3;
    public float smoothing = 5;

    private float lastX = 0;
    private float lastY = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void FixedUpdate() {
        Vector3 goalDirection = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        goalDirection = Vector3.ClampMagnitude(goalDirection, Time.fixedDeltaTime * speed);
        float x = lastX + (goalDirection.x - lastX)/smoothing;
        float y = lastY + (goalDirection.y - lastY)/smoothing;
        transform.Translate(x, y, 0);

        lastX = x;
        lastY = y;
    }

}
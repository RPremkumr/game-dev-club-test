using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{

    public GameObject player;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
        Vector3 goalVector = player.transform.localPosition - transform.localPosition;
        goalVector = Vector3.ClampMagnitude(goalVector, speed * Time.fixedDeltaTime);
        transform.Translate(goalVector.x, goalVector.y, 0);
    }
}

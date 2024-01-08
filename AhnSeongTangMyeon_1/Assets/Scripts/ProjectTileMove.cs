using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectTileMove : MonoBehaviour
{
    public float lifeTime = 2.0f;
    public float moveSpeed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);

        lifeTime -= Time.deltaTime;
        if(lifeTime < 0.0f)
        {
            Destroy(this.gameObject);
        }
    }
}

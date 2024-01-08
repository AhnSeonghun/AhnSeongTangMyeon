using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp_GameObject : MonoBehaviour
{
    public int hp;

    // Start is called before the first frame update
    void Start()
    {
        hp = 50;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            hp -= 1;
        }
    }
}

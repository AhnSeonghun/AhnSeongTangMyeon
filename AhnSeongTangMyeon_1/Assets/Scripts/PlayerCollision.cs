using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public int MAXHP = 25;
    public int Hp;
    public int Mp;

    // Start is called before the first frame update
    void Awake()
    {
        Hp = 25;
        Mp = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

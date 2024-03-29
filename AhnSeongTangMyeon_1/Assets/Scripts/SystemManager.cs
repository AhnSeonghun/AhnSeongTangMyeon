using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemManager : MonoBehaviour
{
    public float roundTime = 0.0f;
    public float roundEndTime = 30.0f;

    public float spawnTime = 0.0f;
    public float nextspawnTime = 2.0f;

    public GameObject[] EnemyObjects;
    public Transform[] spawntransform;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            spawnTime += Time.deltaTime;
            if(nextspawnTime <= spawnTime)
            {
                spawnTime = 0.0f;
                nextspawnTime = Random.Range(0.5f, 2.0f);

                int EnemyObjectsCount =EnemyObjects.Length;
                int spawntransformCount = spawntransform.Length;

                int RandEnemyObjectNumber = Random.Range(0, EnemyObjectsCount);
                int RandSpawntransformNumber = Random.Range(0, spawntransformCount);

                GameObject temp = (GameObject)Instantiate(EnemyObjects[RandEnemyObjectNumber], spawntransform[RandSpawntransformNumber].position, Quaternion.identity);
            }

            if (player.transform.position.y < -50.0f)        //position 의 y 값을 조회는 가능 직접 입력 불가 (Vector3로만 데이터 입력 가능)
            {
                player.GetComponent<PlayerController>().currentHp -= 5;
                player.transform.position = Vector3.zero + new Vector3(0.0f, 1.0f, 0.0f);   //Vector3.zero => new Vector3(0.0f,0.0f,0.0f)
                player.transform.rotation = Quaternion.identity;    //Quaternion.identity => new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);
            }
        }
    }
}
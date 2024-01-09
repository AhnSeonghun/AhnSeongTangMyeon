using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTest : MonoBehaviour
{
    public GameObject Temp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) // 마우스 좌클릭을 했을 때
        {
            Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition); // Ray를 Casting 한다.
            
            RaycastHit hit; // Hit cast 선언

            if(Physics.Raycast(cast, out hit)) // Hit 된 것이 있을 때
            { 
                GameObject temp = Instantiate(Temp);    //오브젝트를 생성
                temp.transform.position = hit.point;    //Hit 된 포인트위치에 놓는다. 
            }
        }

        if(Input.GetMouseButtonDown(1)) // 마우스 우클릭을 했을 때
        {
            Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition); // Ray를 Casting 한다.
            
            RaycastHit hit; // Hit cast 선언

            if(Physics.Raycast(cast, out hit)) // Hit 된 것이 있을 때
            { 
                Debug.Log(hit.collider.gameObject.name); // hit 된 오브젝트의 이름
                Debug.DrawLine(cast.origin, hit.point, Color.red, 2.0f); // 가상의 선을 그림
                Destroy(hit.collider.gameObject);
            }
        }        
    }
}

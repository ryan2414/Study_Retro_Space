using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform childTransform;//움직일 자식 게임 오브젝트의 트랜스폼


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -1, 0);
        childTransform.localPosition = new Vector3(0, 2, 0);

        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 30));
        childTransform.localRotation = Quaternion.Euler(new Vector3(0, 60, 0));
    }

    // Update is called once per frame
    void Update()
    {
        //Tanslate() 평행이동은 전역공간이 아닌 지역공간으로 이루어진다. 
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime);
            //transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime, Space.World);//전역
            //transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime, Space.Self);//지역공간
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 0, 180) * Time.deltaTime);

            childTransform.Rotate(new Vector3(0, 180, 0) * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, -180) * Time.deltaTime);

            childTransform.Rotate(new Vector3(0,-180, 0) * Time.deltaTime);
        }
    }
}

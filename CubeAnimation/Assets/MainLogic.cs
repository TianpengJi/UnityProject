using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainLogic : MonoBehaviour
{
    //ʵ�����˶��߼��ű�
    public CubeMovement cubeMovement;

    // Start is called before the first frame update
    void Start()
    {
        //֡�ʹ̶�60
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        // ��ȡ����ָ�ʹcube�ƶ���  w��ǰ��  s ����   a����    d����
        if (Input.GetKeyDown(KeyCode.W))
        {
            cubeMovement.Xbackward();
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
           cubeMovement.Ybackward();
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            cubeMovement.Xforward();
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            cubeMovement.Yforward();
        }

    }
}

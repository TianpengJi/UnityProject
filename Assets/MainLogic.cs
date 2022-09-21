using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainLogic : MonoBehaviour
{
    //实例化运动逻辑脚本
    public CubeMovement cubeMovement;

    // Start is called before the first frame update
    void Start()
    {
        //帧率固定60
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        // 获取输入指令并使cube移动，  w：前，  s ：后，   a：左，    d：右
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

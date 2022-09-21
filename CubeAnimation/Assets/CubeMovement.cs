using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public Animation anim;//运动组件变量


    void Start()
    {
        anim = GetComponent<Animation>(); //获取动画组件
    }






    public int state = 0; //cube运动状态 用于切换前后左右平移，默认为0
    void Update()
    {
        float d = 2 * Time.deltaTime;     //前后左右平移速度为2， 每帧移动距离为d
        Space space = Space.World;        //使用世界坐标系

        //各状态下实行的平移操作
        switch (state)
        {
            // 状态1：x+
            case 1 : 
                this.transform.Translate(d, 0, 0, space);
                break;

            //状态2： x-
            case 2:
                this.transform.Translate(-d, 0, 0, space);
                break;

            //状态3： z+
            case 3:
                this.transform.Translate(0, 0, d, space);
                break;

            //状态4： z-
            case 4:
                this.transform.Translate(0, 0, -d, space);
                break;
        }
    }






    PlayMode mode = PlayMode.StopAll; //动画播放mode， 各动画独立播放

    //方法用于播放动画及更改运动状态

    public void Xforward()//x轴正方向运动
    {
        Debug.Log("Xforward");
        anim.Play("RotationYRight",mode);//Y轴右旋
        state = 1;
    }

    public void Xbackward()//x轴负方向运动
    {
        Debug.Log("Xbackword");
        anim.Play("RotationYLeft",mode);//Y轴左旋
        state = 2;
    }

    public void Yforward()//y轴正方向运动
    {
        Debug.Log("Yforward");
        anim.Play("RotationXLeft",mode);//X轴左旋
        state = 3;
    }

    public void Ybackward()//y轴负方向运动
    {
        Debug.Log("Xbackward");
        anim.Play("RotationXRight",mode);//x轴右旋
        state = 4;
    }

}
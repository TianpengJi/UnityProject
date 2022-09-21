using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public Animation anim;//�˶��������


    void Start()
    {
        anim = GetComponent<Animation>(); //��ȡ�������
    }






    public int state = 0; //cube�˶�״̬ �����л�ǰ������ƽ�ƣ�Ĭ��Ϊ0
    void Update()
    {
        float d = 2 * Time.deltaTime;     //ǰ������ƽ���ٶ�Ϊ2�� ÿ֡�ƶ�����Ϊd
        Space space = Space.World;        //ʹ����������ϵ

        //��״̬��ʵ�е�ƽ�Ʋ���
        switch (state)
        {
            // ״̬1��x+
            case 1 : 
                this.transform.Translate(d, 0, 0, space);
                break;

            //״̬2�� x-
            case 2:
                this.transform.Translate(-d, 0, 0, space);
                break;

            //״̬3�� z+
            case 3:
                this.transform.Translate(0, 0, d, space);
                break;

            //״̬4�� z-
            case 4:
                this.transform.Translate(0, 0, -d, space);
                break;
        }
    }






    PlayMode mode = PlayMode.StopAll; //��������mode�� ��������������

    //�������ڲ��Ŷ����������˶�״̬

    public void Xforward()//x���������˶�
    {
        Debug.Log("Xforward");
        anim.Play("RotationYRight",mode);//Y������
        state = 1;
    }

    public void Xbackward()//x�Ḻ�����˶�
    {
        Debug.Log("Xbackword");
        anim.Play("RotationYLeft",mode);//Y������
        state = 2;
    }

    public void Yforward()//y���������˶�
    {
        Debug.Log("Yforward");
        anim.Play("RotationXLeft",mode);//X������
        state = 3;
    }

    public void Ybackward()//y�Ḻ�����˶�
    {
        Debug.Log("Xbackward");
        anim.Play("RotationXRight",mode);//x������
        state = 4;
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    public float rotSpeed = 200f;



    float mx = 0;


    void Update()
    {      //���Ӿ�����Ʈ ���°� �ƴϸ� ���� �ߴ�
       // if(GameManager.gm.gState != GameManager.GameState.Run)
       // {
         //   return;
      //  } 
       //1.����ڸ��콺 �Է�
        float mouse_X = Input.GetAxis("Mouse X");

        //2.�Է¹��� ���� ���ؼ� ȸ�� ���� ����
        mx += mouse_X * rotSpeed * Time.deltaTime;


        //3.������ ȸ�������� ����
        transform.eulerAngles = new Vector3(0, mx, 0);

    }

}


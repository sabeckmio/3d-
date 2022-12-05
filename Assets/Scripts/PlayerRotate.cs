using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    public float rotSpeed = 200f;



    float mx = 0;


    void Update()
    {      //게임업데이트 상태가 아니면 게임 중단
       // if(GameManager.gm.gState != GameManager.GameState.Run)
       // {
         //   return;
      //  } 
       //1.사용자마우스 입력
        float mouse_X = Input.GetAxis("Mouse X");

        //2.입력받은 값을 통해셔 회전 방향 결정
        mx += mouse_X * rotSpeed * Time.deltaTime;


        //3.결정된 회전방향을 대입
        transform.eulerAngles = new Vector3(0, mx, 0);

    }

}


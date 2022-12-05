using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletEffect; //총알 이팩트 게임 모브젝트
    //파티클 시스템 게임 오브젝트
    ParticleSystem ps;
    AudioSource aSource;
    void Start()
    {//파티클 시스템 컴퍼넌트 기져오기
        ps = bulletEffect.GetComponent<ParticleSystem>();



       aSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

            RaycastHit hitInfo = new RaycastHit();


            if (Physics.Raycast(ray, out hitInfo))
            {
                print(hitInfo.transform.name); //이름생성-시험
                bulletEffect.transform.position = hitInfo.point;
                //부딫힌 위치에 총알 이팩트 오브젝트 위치
                bulletEffect.transform.forward = hitInfo.normal; //총알 이팩트의 방향을 부딪힌 오브젝트 표면의 수직방향(노멀 벡터)와 일치시킨다.

                ps.Play();
            }
            aSource.Play();



        }



    }
}


   

    



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletEffect; //�Ѿ� ����Ʈ ���� �����Ʈ
    //��ƼŬ �ý��� ���� ������Ʈ
    ParticleSystem ps;
    AudioSource aSource;
    void Start()
    {//��ƼŬ �ý��� ���۳�Ʈ ��������
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
                print(hitInfo.transform.name); //�̸�����-����
                bulletEffect.transform.position = hitInfo.point;
                //�΋H�� ��ġ�� �Ѿ� ����Ʈ ������Ʈ ��ġ
                bulletEffect.transform.forward = hitInfo.normal; //�Ѿ� ����Ʈ�� ������ �ε��� ������Ʈ ǥ���� ��������(��� ����)�� ��ġ��Ų��.

                ps.Play();
            }
            aSource.Play();



        }



    }
}


   

    



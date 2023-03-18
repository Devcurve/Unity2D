using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundController : MonoBehaviour
{
    private Transform[] backGround = new Transform[7];
    private float[] offsets = new float[7];
    private float speed;
    
    void Start()
    {
        for (int i = 0; i < transform.childCount; ++i)
            backGround[i] = transform.GetChild(i);

        speed = 5.0f;
        
        offsets[0] = 2.0f;
        offsets[1] = 1.5f;
        
        offsets[2] = 1.0f;
        
        offsets[3] = 0.5f;
        offsets[4] = 0.25f;
        offsets[5] = 0.125f;
        offsets[6] = 0.0625f;
    }
    void Update()
    {
        //Transpos.position -= new Vector3(Time.deltaTime * Movemanet.x * 5.0f, 0.0f, 0.0f);
        
        Vector3 Movemanet = new Vector3(
            ControllerManager.Getinstance.Hor,
            ControllerManager.Getinstance.Ver,
            0.0f);
        
        for (int i = 0; i < transform.childCount; ++i)
        {
            backGround[i].position -= new Vector3(Time.deltaTime * Movemanet.x * speed * offsets[i], 0.0f, 0.0f);
        
            if (backGround[i].position.x < -50f)
                backGround[i].position = new Vector3(0.0f, 0.0f, 0.0f);    
        }
        
        /*
        if (Transpos.position.x < -50f)
            Transpos.position = new Vector3(0.0f, 0.0f, 0.0f);
         */
    }
}

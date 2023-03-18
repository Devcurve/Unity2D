using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerManager : MonoBehaviour
{
    private ControllerManager() { } 
    private static ControllerManager instance = null;

    public static ControllerManager Getinstance
    {
        get
        {
            if (instance == null)
                return null;
            
            return instance;
        }
    }

    [HideInInspector] public float Hor;
    [HideInInspector] public float Ver;
    
    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    private void Start()
    {
        Hor = 0.0f;
        Ver = 0.0f;
    }

    void Update()
    {
        // ** GetAxis = 실수 반환 : Key Up & Down 모두 점진적 값을 반환한다. 
        // **  - 키 입려시 0에서 1 방향으로 프래임마다 적용된 실수값을 반환. 
        
        // ** GetAxisRaw = -1 , 0, 1 세가지 값만 반환 한다.
        Hor = Input.GetAxisRaw("Horizontal");
        Ver = Input.GetAxisRaw("Vertical");
    }
}

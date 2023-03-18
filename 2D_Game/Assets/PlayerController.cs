using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator Anim;
    private SpriteRenderer renderer;
    void Start()
    {
        Anim = GetComponent<Animator>();
        renderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Vector3 Movemanet = new Vector3(
            ControllerManager.Getinstance.Hor,
            ControllerManager.Getinstance.Ver,
            0.0f);

        if (Movemanet.x != 0)
            renderer.flipX = (Movemanet.x < 0) ? true : false;
        
        Anim.SetFloat("Speed", Movemanet.x);
    }
}

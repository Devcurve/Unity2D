using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    private Animator Anim;
    private SpriteRenderer renderer;
    
    private Vector3 Movemanet;

    private void Awake()
    {
        Anim = GetComponent<Animator>();
        renderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        transform.position = new Vector3(-5.0f, -7.7f, 0.0f);
        
        Movemanet = Vector3.zero;
    }

    void Update()
    {
        Vector3 offset = ControllerManager.Getinstance.offset;
        Vector3 MovingBox = ControllerManager.Getinstance.MovingBox;

        if (transform.position.x < offset.x + MovingBox.x && 
            transform.position.x > offset.x - MovingBox.x)
        {
            Movemanet = new Vector3(
                ControllerManager.Getinstance.Hor, 0.0f, 0.0f);
            
            transform.position += Movemanet * Time.deltaTime * 5.0f;

            if (transform.position.x > 8.0f)
                transform.position = new Vector3(7.9f, transform.position.y, 0.0f);
            
            if (transform.position.x < -18.0f)
                transform.position = new Vector3(-17.9f, transform.position.y, 0.0f);
        }
        
        if (Movemanet.x != 0)
            renderer.flipX = (Movemanet.x < 0) ? true : false;
        
        Anim.SetFloat("Speed", Movemanet.x);
    }
}

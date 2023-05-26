using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAnimation : MonoBehaviour
{
    public Animator anim;


    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    public void OnPress()
    {
        anim.SetTrigger("NewTrigger");
    }
}

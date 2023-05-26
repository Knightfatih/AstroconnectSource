using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    Controller controls;

    Vector2 dirLeft;
    Vector2 dirRight;

    public FindNode scriptNode;

    public LevelManager levelManager;

    private void Awake()
    {
        levelManager = gameObject.GetComponentInParent<LevelManager>();

        scriptNode = gameObject.GetComponent<FindNode>();

        controls = new Controller();

        controls.Game.A.performed += ctx => ButtonA();  // A
        controls.Game.B.performed += ctx => ButtonB();  // B

        controls.Game.LeftThumb.performed += ctx => dirLeft = ctx.ReadValue<Vector2>(); // left thumb
        controls.Game.LeftThumb.performed += ctx => dirRight = ctx.ReadValue<Vector2>(); // right thumb

        controls.Game.LeftThumb.canceled += ctx => dirLeft = ctx.ReadValue<Vector2>();
    }

    private void OnEnable()
    {
        controls.Game.Enable();
    }

    private void OnDisable()
    {
        controls.Game.Disable();
    }

    void ButtonA()
    {
        Debug.Log("A");
    }

    void ButtonB()
    {
        Debug.Log("B");
        // Access current level and restart

        levelManager.RestartCurrentLevel();
    }

    private void Update()
    {
        if (dirLeft.sqrMagnitude > 0.9 )
        {
        scriptNode.DrawRay(dirLeft);

        }

        if (dirLeft != Vector2.zero)
        {
        //Debug.Log(dirLeft);
         // Call Function


        }

        if (dirRight != Vector2.zero)
        {
           //Debug.Log(dirRight);

        }



    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : Interactable
{
    int sens = 1;
    int acc = 0;
    bool isRotating = false;
    bool isLocked = true;

    public GameObject Door;

    public override void Interact()
    {
        if(!isLocked)
        {
            isRotating = true;
            base.Interact();
        }
    }
    public override void Update()
    {
        base.Update();
        if (isRotating)
        {
            Door.transform.Rotate(Vector3.up * sens);
            acc++;
            if (acc == 90)
            {
                acc = 0;
                sens *= -1;
                isRotating = false;
            }
        }
    }

    public void unlock()
    {
        isLocked = false;
    }
}

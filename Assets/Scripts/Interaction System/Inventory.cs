﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Inventory : MonoBehaviour
{
    public bool HasKey = false;

    public void Update()
    {
        if (Keyboard.current.qKey.wasPressedThisFrame) HasKey = !HasKey;
        
    }
}

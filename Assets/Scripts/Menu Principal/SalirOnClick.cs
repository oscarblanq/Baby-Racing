﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalirOnClick : MonoBehaviour
{
    public void Salir()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> where T : Component
{
    static T _instance = null;
    static public T Instance()
    {
        if (_instance == null)
        {
            _instance = Object.FindObjectOfType<T>();
            if (_instance == null)
            {
                var go = new GameObject();
                _instance = go.AddComponent<T>();
            }
        }
        return _instance;
    }
}
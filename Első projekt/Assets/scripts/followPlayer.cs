﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject player;
    private Vector3 offset = new Vector3(-30, 0, 10);
    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}

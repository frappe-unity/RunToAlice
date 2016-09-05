﻿using UnityEngine;
using System.Collections;

public class BackGround : MonoBehaviour
{
    //public float scrollSpeed = 1f;

    void Start()
    {
        GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", Vector2.zero);
    }

    void Update()
    {
        ScrollTexture();
    }

    void ScrollTexture()
    {
        var x = Mathf.Repeat(Time.time * GameManager.textureSpeed, 100);

        var offset = new Vector2(x, 0);

        GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}

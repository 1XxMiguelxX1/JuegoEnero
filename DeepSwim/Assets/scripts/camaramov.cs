using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaramov : MonoBehaviour
{
    public RawImage _img;
    public float _x;
    public float _y;

    void Update()
    {
        _img.uvRect = new Rect(_img.uvRect.position + new Vector2(_x, _y) * Time.deltaTime, _img.uvRect.size);
    }
}
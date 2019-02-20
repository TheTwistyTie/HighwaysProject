using System;
using UnityEngine;
using BansheeGz.BGSpline.Curve;

public struct Path
{

    public GameObject gameObject;
    public BGCurve curve;

    public Path(Vector3 pos)
    {
        gameObject = new GameObject();
        gameObject.transform.position = pos;
        gameObject.AddComponent<BGCurve>();
        curve = gameObject.GetComponent<BGCurve>();
    }

}


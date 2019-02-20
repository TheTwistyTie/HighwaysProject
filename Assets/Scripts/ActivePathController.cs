using UnityEngine;
using System;
using System.Collections.Generic;
using BansheeGz.BGSpline.Components;
using BansheeGz.BGSpline.Curve;

public class ActivePathController : MonoBehaviour
{
    Path p;
    List<GameObject> pathGameObjects = new List<GameObject>();

    BGCurvePointI selectedPoint;

    public Path Path
    {
        get
        {
            return p;
        }
        set
        {
            if (p.IsEqual(value))
            {
                p = value;
            }
            else
            {

                p = value;

                foreach (GameObject gO in pathGameObjects)
                {
                    Destroy(gO);
                }

                pathGameObjects = new List<GameObject>();
                Redraw();
            }
        }
    }

    void Redraw()
    {
        var points = p.curve.Points;
        if (points.Length < 0)
        {
            foreach (var point in points)
            {
                pathGameObjects.Add(CreatePointHandel(point.PositionWorld));
            }
        }
    }

    GameObject CreatePointHandel(Vector3 pos)
    {
        GameObject pointHandle = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        pointHandle.transform.position = pos;
        pointHandle.transform.localScale = new Vector3(.1f, .1f, .1f);
        return pointHandle;
    }

    // Update is called once per frame
    void Update()
    {
        if (p.curve.Points.Length < 0)
        {
            foreach (BGCurvePoint point in p.curve.Points)
            {

            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                p.curve.AddPoint(new BGCurvePoint(p.curve, Camera.main.ScreenToWorldPoint(Input.mousePosition), true));
            }
        }
    }
}

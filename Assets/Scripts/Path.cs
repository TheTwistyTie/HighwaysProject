using System;
using UnityEngine;
using BansheeGz.BGSpline.Curve;
using BansheeGz.BGSpline.Components;

public class Path
{

    public GameObject gameObject;
    public BGCurve curve;
    public BGCcCollider3DBox collider;
    public BGCcVisualizationLineRenderer renderer;
    public PathController controller;

    public int index;

    public Path(Vector3 pos, int index)
    {

        this.index = index;

        gameObject = new GameObject();
        gameObject.transform.position = pos;

        gameObject.AddComponent<BGCurve>();
        curve = gameObject.GetComponent<BGCurve>();

        gameObject.AddComponent<BGCcCollider3DBox>();
        collider = gameObject.GetComponent<BGCcCollider3DBox>();

        gameObject.AddComponent<BGCcVisualizationLineRenderer>();
        renderer = gameObject.AddComponent<BGCcVisualizationLineRenderer>();

        gameObject.AddComponent<PathController>();
        controller = gameObject.GetComponent<PathController>();
        controller.path = this;

    }

    public void SetParent(Transform t)
    {
        gameObject.transform.SetParent(t);
    }
}


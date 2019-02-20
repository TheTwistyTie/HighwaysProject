using System;
using UnityEngine;
using BansheeGz.BGSpline.Curve;
using BansheeGz.BGSpline.Components;

public class Path
{

    GameManager game;

    public GameObject gameObject;
    public BGCurve curve;
    public BGCcCollider3DBox collider;
    public BGCcVisualizationLineRenderer renderer;

    public int index;

    public Path(Vector3 pos, GameManager game, int index = 0)
    {

        this.index = index;
        this.game = game;

        gameObject = new GameObject();
        gameObject.transform.position = pos;

        gameObject.AddComponent<BGCurve>();
        curve = gameObject.GetComponent<BGCurve>();

        gameObject.AddComponent<BGCcCollider3DBox>();
        collider = gameObject.GetComponent<BGCcCollider3DBox>();
        renderer = gameObject.AddComponent<BGCcVisualizationLineRenderer>();

        SetActive();

    }

    public void SetParent(Transform t)
    {
        gameObject.transform.SetParent(t);
    }

    void SetActive()
    {
        game.ActivePath = this;
    }

    public bool IsEqual(Path x)
    {
        return x.gameObject.Equals(gameObject) && x.curve == curve && x.index == index;
    }
}


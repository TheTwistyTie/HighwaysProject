using System.Collections.Generic;
using UnityEngine;
using BansheeGz.BGSpline.Curve;

public class GameManager : MonoBehaviour
{
    public Camera mainCamera;
    public Path ActivePath;

    private void Update()
    {

    }

    List<Path> paths = new List<Path>();

    public void CreateNewPath()
    {

        paths.Add(new Path(Vector3.zero, this, paths.Count));

        paths[paths.Count - 1].SetParent(transform);

    }

}

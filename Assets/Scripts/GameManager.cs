using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BansheeGz.BGSpline.Curve;

public class GameManager : MonoBehaviour
{

    public GameObject ActivePath;

    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.RightControl)) && Input.GetMouseButtonDown(0))
        {
            CreateNewPath(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }
    }

    List<Path> paths = new List<Path>();

    void CreateNewPath(Vector3 pos)
    {

        paths.Add(new Path(pos, paths.Count));
        paths[paths.Count - 1].SetParent(transform);

    }

}

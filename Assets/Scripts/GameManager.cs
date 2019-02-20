using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BansheeGz.BGSpline.Curve;

public class GameManager : MonoBehaviour
{

    List<Path> paths = new List<Path>();

    void CreateNewPath(Vector3 pos)
    {

        paths.Add(new Path(pos));

    }

}

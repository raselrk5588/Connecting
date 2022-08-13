using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RanderLine : MonoBehaviour
{
    public LineRenderer lineRenderer;
    // public GameObject line;
    Vector3 start;
    Vector3 end;

    Vector3 camOffset = new Vector3(0, 0, 1);


    public void StartingPosition()
    {

        start = Camera.main.ScreenToWorldPoint(Input.mousePosition) + camOffset;
        start.z=0;
      //  Debug.Log(start);
        lineRenderer.SetPosition(0, start);
      //  Debug.Log("StartingPosition");

    }
    public void EndingPosition()
    {
        end = Camera.main.ScreenToWorldPoint(Input.mousePosition) + camOffset;
        end.z=0;
      //  Debug.Log(end);
        lineRenderer.SetPosition(1, end);
       // Debug.Log("EndingPosition");

    }

}






















// public void CreatRanderstart(Vector3 _start)
// {
//     _start = Camera.main.ScreenToWorldPoint(Input.mousePosition) ;
//     lineRenderer.SetPosition(0, _start);


// }
// public void CreatRanderEnd(Vector3 _end)
// {
//     _end = Camera.main.ScreenToWorldPoint(Input.mousePosition) ;
//     lineRenderer.SetPosition(1, _end);
// }

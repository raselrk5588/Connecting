using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TailManager : MonoBehaviour
{
    // public GameObject line;
    public Transform holder;
    public LineRenderer lineRenderer;
    public int lineCounter;
    //next time check
    public void LineRanderFinal(int i, int j)
    {
        Vector3 st = transform.GetChild(i).position;
        st.z = 100;
        Vector3 en = transform.GetChild(j).position;
        en.z = 100;
        lineRenderer.SetPosition(0, st);
        lineRenderer.SetPosition(1, en);
        lineCounter++;
        Instantiate(lineRenderer, holder);

    }

}

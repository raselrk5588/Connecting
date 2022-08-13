using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Tail : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler, IDropHandler, IPointerEnterHandler, IPointerExitHandler, IPointerMoveHandler
{
    public GameMnager gameMnager;
    public GameObject tailBoader;
    public bool isRight;
    public bool isLeft;
    public int Index;

    private int BorderCounter;
    public string ItemName;



    public void OnDrag(PointerEventData eventData)
    {
        gameMnager.randerLine.EndingPosition();

    }

    public void OnDrop(PointerEventData eventData)
    {

        if (isRight || isLeft)
        {
            gameMnager.FinalLinne(this);
            gameMnager.TwoPointerConnecte(this);
            tailBoader.SetActive(true);
            Tail.Destroy(this);
            Tail.Destroy(gameMnager.CurrentTail);
            gameMnager.uIManager.TailAnimationReset(this);

        }



    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isLeft = true;
        Debug.Log(name);
        gameMnager.Create(this);
        tailBoader.SetActive(true);
        gameMnager.randerLine.lineRenderer.enabled = true;
        gameMnager.randerLine.StartingPosition();
        gameMnager.uIManager.TailAnimationReset(this);


    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        gameMnager.uIManager.tailAnimation(this);
        tailBoader.SetActive(true);
        // Debug.Log("OnPointer Enter");

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (!isLeft)
        {
            tailBoader.SetActive(false);
        }


    }

    public void OnPointerMove(PointerEventData eventData)
    {
        //  tailBoader.SetActive(false);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        tailBoader.SetActive(false);
        gameMnager.uIManager.TailAnimationReset(this);
        gameMnager.randerLine.lineRenderer.enabled = false;

    }
}

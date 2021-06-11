﻿using MyOwnClass;
using UnityEngine;
using UnityEngine.EventSystems;

[SerializeField]
public class Building : MonoBehaviour, IPointerClickHandler
{
    public string streetName = "";
    public string description = "";
    

    public void OnPointerClick(PointerEventData eventData)
    {
        ArrowsController.instance.activeObject = this;
        if (gameObject != DifferentThings.allRealObjects[DifferentThings.numberOfActiveObject])
        {
            for (int i = 0; i < DifferentThings.allRealObjects.Count; i++)
            {
                if (DifferentThings.allRealObjects[i] == gameObject)
                {
                    DifferentThings.numberOfActiveObject = i;
                }
            }
        }
        ArrowsController.instance.UseArrows();
        ArrowsController.instance.UpdateText();
    }
}
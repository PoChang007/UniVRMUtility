﻿using UnityEngine;
using UnityEngine.EventSystems;

namespace UniVRMUtility.VRMViewer
{
    public class UISlider : MonoBehaviour, IEndDragHandler, IBeginDragHandler
    {
        [SerializeField]
        public bool isBeingDragged = false;

        public bool IsBeingDragged()
        {
            return isBeingDragged;
        }
        public void OnEndDrag(PointerEventData data)
        {
            isBeingDragged = false;
        }

        public void OnBeginDrag(PointerEventData data)
        {
            isBeingDragged = true;
        }

    }

}

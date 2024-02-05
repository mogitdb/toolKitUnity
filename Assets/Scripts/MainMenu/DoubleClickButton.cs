using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class DoubleClickButton : MonoBehaviour, IPointerClickHandler
{
    public float doubleClickThreshold = 0.25f; // Time within two clicks must occur to be considered a double-click
    private float lastClickTime;

    // Event to subscribe to for a double-click
    public delegate void DoubleClickAction();
    public event DoubleClickAction OnDoubleClick;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.clickCount == 2)
        {
            OnDoubleClick?.Invoke();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClickManager : MonoBehaviour
{


    [SerializeField]
    private Camera cam;


    [SerializeField]
    private GraphicRaycaster graphicRayCaster;

    [SerializeField]
    private EventSystem eventSystem;

    private PointerEventData pointerData;



    private void Awake()
    {
        pointerData = new PointerEventData(null);
    }





    public static event Action CloseAllPanels = delegate { };




    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {

            pointerData.position = Input.mousePosition;

            List<RaycastResult> results = new List<RaycastResult>();

            graphicRayCaster.Raycast(pointerData, results);


            if (results.Count > 0)
                return;
        





            Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if(hit)
            {
                IClickable clickable = hit.collider.GetComponent<IClickable>();
                clickable?.Click();


            }
            else
            {
                CloseAllPanels();
            }





        }
    }



    public static void CallCloseAllPanels()
    {
        CloseAllPanels();
    }

}

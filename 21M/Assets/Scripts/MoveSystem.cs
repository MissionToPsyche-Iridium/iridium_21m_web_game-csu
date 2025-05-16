using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class MoveSystem : MonoBehaviour
{

    public GameObject correctPos;
    private bool moving;
    private bool finish;

    private float startPosX;
    private float startPosY;

    private Vector3 resetPosition;
    private PointsHandler pointsHandler;
    void Start()
    {
        resetPosition = this.transform.position;
        pointsHandler = GameObject.Find("PointsHandler").GetComponent<PointsHandler>();
    }

    void Update()
    {

        if (finish == false)
        {
            if (moving)
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);
                this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
            }
        }
        
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            moving = true; //player will be able to keep moving the piece around 

        }
        
    }

    private void OnMouseUp()
    {
        moving = false; //player won't be able to move the piece anymore since it is in the correct position 

        if (Mathf.Abs(this.transform.localPosition.x - correctPos.transform.localPosition.x) <= 0.5f && 
            Mathf.Abs(this.transform.localPosition.y - correctPos.transform.localPosition.y) <= 0.5f)
        {
            this.transform.localPosition = new Vector3(correctPos.transform.localPosition.x, correctPos.transform.localPosition.y, correctPos.transform.localPosition.z);
          //  finish = true;

            if (!finish)
            {
                finish = true;
                pointsHandler.PiecePlaced();
            }

            // Load next scene

        }
        else
        {
         // this.transform.localPosition = new Vector3(resetPosition.x, resetPosition.y, 10);
          
        }
    }
}

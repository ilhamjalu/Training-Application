using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScript : MonoBehaviour
{
    Renderer renderer;
    public bool isMove;
    public bool inOrder;
    public float distance;
    public int orderNumber;
    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        renderer = gameObject.GetComponent<Renderer>();
        gameManager = GameObject.Find("Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isMove)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            transform.position = rayPoint;
        }

        if(gameManager.nowOrder == orderNumber)
        {
            inOrder = true;
        }
        else
        {
            inOrder = false;
        }
    }

    private void OnMouseEnter()
    {
        renderer.material.color = Color.red;
    }

    private void OnMouseExit()
    {
        renderer.material.color = Color.blue;
    }

    private void OnMouseUp()
    {
        isMove = false;
    }

    private void OnMouseDown()
    {
        if(inOrder == true)
        {
            isMove = true;
            distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        }
    }
}

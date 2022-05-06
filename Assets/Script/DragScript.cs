using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragScript : MonoBehaviour
{
    Renderer renderer;
    public bool isMove;
    public float distance;

    // Start is called before the first frame update
    void Start()
    {
        renderer = gameObject.GetComponent<Renderer>();
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
        isMove = true;
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);
    }

    //private void OnMouseDrag()
    //{
    //    Vector3 pos_Mouse = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));
    //    transform.position = new Vector3(pos_Mouse.x, pos_Mouse.y, transform.position.z);
    //    //transform.localScale = new Vector2(0.4f, 0.4f);
    //}
}
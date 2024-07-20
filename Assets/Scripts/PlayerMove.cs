using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : AIMove
{
    bool moving;
    // Start is called before the first frame update
    private void Start()
    {
        Init();
    }

    // Update is called once per frame
    public void Update()
    {
        if (!isMoving)
        {
            FindSelectableTiles();
            CheckMouse();
        }
        else
        {
            Move();
        }
    }

    void CheckMouse()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Tile")
                {
                    Tile t = hit.collider.GetComponent<Tile>();
                    if (t.selectable)
                    {
                        MoveToTile(t);
                    }
                }
            }
        }
    }
}

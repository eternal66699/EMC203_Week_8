using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMove : MonoBehaviour
{
    List<Tile> selectableTiles = new();
    GameObject[] tiles;
    public int move = 5;
    public float jumpHeight = 2;
    public float moveSpeed;

    Stack<Tile> path = new();
    Tile currentTile;

    Vector3 velocity = new();
    Vector3 heading = new();

    float halfHeight = 0;
    protected void Init()
    {
        tiles = GameObject.FindGameObjectsWithTag("Tile");

        halfHeight = GetComponent<Collider>().bounds.extents.y;
    }

    public void GetCurrentTile()
    {
        currentTile = GetTargetTile(gameObject);
        currentTile.current = true;
    }

    public Tile GetTargetTile(GameObject target)
    {
        Tile tile = null;
        return tile;
    }
}

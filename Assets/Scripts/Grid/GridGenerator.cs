using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    public int width, height, depth;
    public GameObject tilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        //GenerateGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateGrid()
    {
        if (tilePrefab == null)
        {
            Debug.LogError("No Prefab Assigned");
            return;
        }
        //Loop through the grid positions
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                for (int z = 0; z < depth; z++)
                {
                    //calculate the position for each cube
                    Vector3 position = new Vector3(x, y, z);
                    //Instantiate the cube at the calculated position
                    GameObject newTile = Instantiate(tilePrefab, position, Quaternion.identity);
                    newTile.transform.parent = transform;
                    newTile.tag = "Tile";
                }
            }
        }
    }

    public void ClearGrid()
    {
        //Find all GameObject tagged as "Tiles"
        GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");
        foreach (GameObject tile in tiles)
        {
            DestroyImmediate(tile);
        }
    }

    public void AssignMaterial()
    {
        //Find all GameObject with tag as "Tile"
        GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");
        //Find the material in resources folder with the name Tile
        Material material = Resources.Load<Material>("Tile");
        foreach (GameObject t in tiles)
        {
            t.GetComponent<Renderer>().material = material;
        }
    }

    public void AssignTileScript()
    {
        GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");
        foreach(GameObject tile in tiles)
        {
            tile.AddComponent<Tile>();
        }
    }
}

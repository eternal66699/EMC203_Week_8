using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GridGenerator))]
public class GridGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        GridGenerator gridGenerator = (GridGenerator)target;
        if (GUILayout.Button("Generate Grid"))
        {
            gridGenerator.GenerateGrid();
        }
        if (GUILayout.Button("Delete Grid"))
        {
            gridGenerator.ClearGrid();
        }
        if (GUILayout.Button("Assign Material"))
        {
            gridGenerator.AssignMaterial();
        }
        if (GUILayout.Button("Assign Tile Script"))
        {
            gridGenerator.AssignTileScript();
        }
    }

    //optional
    [MenuItem("Tools/Generate Grid")]

    public static void GenerateGridMenu()
    {
        GridGenerator gridGenerator = FindObjectOfType<GridGenerator>();
        if (gridGenerator != null)
        {
            gridGenerator.GenerateGrid();
        }
        else
        {
            Debug.LogError("No Grid Generator found in scene.");
        }
    }

    [MenuItem("Tools/Delete Grid")]

    public static void DeleteGridMenu()
    {
        GridGenerator gridGenerator = FindObjectOfType<GridGenerator>();
        if (gridGenerator != null)
        {
            gridGenerator.ClearGrid();
        }
    }
    //end of optional
}

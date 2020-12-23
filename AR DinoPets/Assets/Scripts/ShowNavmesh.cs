using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ShowNavmesh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void ShowMesh()
    {
        NavMeshTriangulation meshData = NavMesh.CalculateTriangulation();

        Mesh mesh = new Mesh();
        mesh.vertices = meshData.vertices;
        mesh.triangles = meshData.indices;

        GetComponent<MeshFilter>().mesh = mesh;
    }

    // Update is called once per frame
    void Update()
    {
        ShowMesh();
    }
}

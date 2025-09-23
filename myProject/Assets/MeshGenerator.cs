using UnityEngine;



[RequireComponent(typeof(MeshFilter))]

public class MeshGenerator : MonoBehaviour
{

    private Mesh mesh; //Mesh type variable that stored the mesh data
    private Vector3[] caveVertices;
    int[] caveTriangles;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mesh = new Mesh(); // make it an object
        GetComponent<MeshFilter>().mesh = mesh;   //add our mesh to the mesh filter

        createShape();
    }

    // Update is called once per frame
    void createShape()
    {

     caveVertices = new Vector3[]  //array of all the caveVertices we have
        {

            new Vector3 (0,0,0),
            new Vector3 (0,0,1),
            new Vector3 (1,0,0),
            new Vector3 (1,0,1)

        };

        caveTriangles = new int[] //array of triangles, represented by 3 caveVertices. you reference these caveVertices as indexes of the caveVertices array
        {
            0, 1, 2,
            1, 2, 3
        };
    }

    void updateMesh ()
    {
        mesh.Clear();
        mesh.vertices = caveVertices;
        mesh.triangles = caveTriangles;
        mesh.RecalculateNormals();
    }

}

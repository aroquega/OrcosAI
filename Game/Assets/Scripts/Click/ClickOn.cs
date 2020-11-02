using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOn : MonoBehaviour
{
    // Start is called before the first frame update
    public Material green;
    public Material black;
    private MeshRenderer mesh;
    public bool isSelected = false;
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        ClickMe();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickMe()
    {
        mesh.material = isSelected ? green : black;
    }

}

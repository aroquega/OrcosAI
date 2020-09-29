using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionController : MonoBehaviour
{
    public List<Orc> selected;
    ParticleSystem particleSystem;
    void Start()
    {
        //particleSystem = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Vector3 mousePosition = Input.mousePosition;
            foreach (Orc orc in selected)
            {

                Ray ray = Camera.main.ScreenPointToRay(mousePosition);
                RaycastHit hitData;

                if (Physics.Raycast(ray, out hitData, 20))
                {
                    Debug.Log(hitData.point);
                    orc.transform.position = hitData.point;
                }
            }
        }
    }
}

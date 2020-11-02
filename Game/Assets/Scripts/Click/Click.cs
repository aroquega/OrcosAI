using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public LayerMask clickablesLayer;
    public List<GameObject> selectedUnits;

        // Start is called before the first frame update
    void Start()
    {
        selectedUnits = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit rayHit;
            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out rayHit,Mathf.Infinity, clickablesLayer))
            {
                ClickOn clickOn =  rayHit.collider.GetComponent<ClickOn>();
                if(clickOn.isSelected == false)
                {
                    selectedUnits.Add(rayHit.collider.gameObject);
                    clickOn.isSelected = true;
                    clickOn.ClickMe();
                }
                else
                {
                    selectedUnits.Remove(rayHit.collider.gameObject);
                    clickOn.isSelected = false;
                    clickOn.ClickMe();
                }
            }
            else
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                Vector3 destino;
                if (Physics.Raycast(ray, out hit))
                {
                    destino = hit.point;
                    Debug.Log(destino);
                    if (selectedUnits.Count > 0)
                    {
                        foreach (GameObject obj in selectedUnits)
                        {
                            obj.GetComponent<UnitPath>().desplazarme(destino);
                        }
                    }
                }
               

            }
        }
    }
}

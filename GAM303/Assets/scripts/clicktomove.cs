using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class clicktomove : MonoBehaviour
{          
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            Physics.Raycast(ray, out hit);

            if (hit.collider.gameObject != null)
            {
                Vector3 newTarget = hit.point + new Vector3(0, 0.5f, 0);
                transform.DOMove(newTarget, 1f);
            }
        }
    } 

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Tweening : MonoBehaviour {



    public GameObject cube;
    public float tweenSpeed = 2f;
	
	
	// Update is called once per frame
	void Update ()

    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            cube.transform.DOScale(4, tweenSpeed);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            cube.transform.DOMoveX(10, tweenSpeed);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            cube.transform.DOPunchPosition(Vector3.forward*10, tweenSpeed,1,1f);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Camera.main.DOShakePosition(tweenSpeed, 3, 5, 45);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            cube.GetComponent<Renderer>().material.DOColor(Color.blue, tweenSpeed);
        }
    }
}

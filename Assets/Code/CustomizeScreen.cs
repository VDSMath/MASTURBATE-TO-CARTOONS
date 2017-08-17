using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizeScreen : MonoBehaviour {

    private bool focused;
    private Camera main;
    private GameObject girl;
    private float initialCameraSize;
    private Vector3 initialCameraPosition;

    [SerializeField]
    private float cameraZoomAmount;
    [SerializeField]
    private GameObject customizeButtons;

	// Use this for initialization
	void Start () {
        focused = false;
        girl = GameObject.Find("cute");
        main = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Click()
    {
        if (!focused)
        {
            FocusOnGirl();
        }
        else
        {
            FocusOut();
        }
    }

    private void FocusOnGirl()
    {
        customizeButtons.SetActive(true);
        initialCameraPosition = main.transform.position;
        initialCameraSize = main.orthographicSize;
        focused = true;
        main.transform.position = new Vector3(girl.transform.position.x, girl.transform.position.y, main.transform.position.z);
        main.orthographicSize = cameraZoomAmount;
    }

    private void FocusOut()
    {
        customizeButtons.SetActive(false);
        focused = false;
        main.transform.position = initialCameraPosition;
        main.orthographicSize = initialCameraSize;
    }
}

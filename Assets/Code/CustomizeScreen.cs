using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizeScreen : MonoBehaviour {

    private bool focused;
    private Camera main;

    [SerializeField]
    private GameObject girl;

    private float initialGirlScale;
    private Vector3 initialGirlPosition;

    [SerializeField]
    private Vector3 newGirlPosition;
    [SerializeField]
    private float newGirlScale;
    [SerializeField]
    private GameObject customizeButtons;

	// Use this for initialization
	void Start () {
        focused = false;
        main = Camera.main;
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
        focused = true;
        initialGirlPosition = girl.transform.position;
        initialGirlScale = girl.transform.localScale.x;
        girl.transform.position = newGirlPosition;
        girl.transform.localScale = new Vector3(newGirlScale, newGirlScale);
    }

    private void FocusOut()
    {
        customizeButtons.SetActive(false);
        focused = false;
        girl.transform.position = initialGirlPosition;
        girl.transform.localScale = new Vector3(initialGirlScale, initialGirlScale);
    }
}

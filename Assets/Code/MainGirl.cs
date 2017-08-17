using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGirl : MonoBehaviour {

    [SerializeField]
    private SpriteRenderer headRenderer, torsoRenderer, legRenderer;

    [SerializeField]
    private OutfitObject current;

    [SerializeField]
    private List<Sprite> headOptions, torsoOptions, legOptions;
    private int currentHead, currentTorso, currentLeg;

    [HideInInspector]
    public bool next;

	// Use this for initialization
	void Start () {
        currentTorso = currentLeg = currentTorso = 0;

        headRenderer.sprite = current.headSprite;
        torsoRenderer.sprite = current.torsoSprite;
        legRenderer.sprite = current.legSprite;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeNext(bool n)
    {
        next = n;
    }

    public void ChangeOutfit(string part)
    {
        switch (part)
        {
            case "head":
                currentHead = next ? currentHead + 1 : currentHead - 1;
                currentHead = currentHead > headOptions.Capacity - 1 ? currentHead - headOptions.Capacity : currentHead;
                currentHead = currentHead < 0 ? headOptions.Capacity - 1 : currentHead;
                headRenderer.sprite = headOptions[currentHead];
                break;

            case "torso":
                currentTorso = next ? currentTorso + 1 : currentTorso - 1;
                currentTorso = currentTorso > torsoOptions.Capacity - 1 ? currentTorso - torsoOptions.Capacity : currentTorso;
                currentTorso = currentTorso < 0 ? torsoOptions.Capacity - 1 : currentTorso;
                torsoRenderer.sprite = torsoOptions[currentTorso];
                break;

            case "leg":
                currentLeg = next ? currentLeg + 1 : currentLeg - 1;
                currentLeg = currentLeg > legOptions.Capacity - 1 ? currentLeg - legOptions.Capacity : currentLeg;
                currentLeg = currentLeg < 0 ?  legOptions.Capacity - 1 : currentLeg;
                legRenderer.sprite = legOptions[currentLeg];
                break;
        }
    }
}

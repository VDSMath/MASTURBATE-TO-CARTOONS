using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGirl : MonoBehaviour {

    [Header("Images")]
    [SerializeField] private Image hairBackImage;
    [SerializeField] private Image torsoImage;
    [SerializeField] private Image faceImage;
    [SerializeField] private Image hairImage;
    [SerializeField] private Image eyesImage;
    [SerializeField] private Image mouthImage;
    [SerializeField] private Image noseImage;

    [Header("Current SO")]
    [SerializeField]
    private OutfitObject current;

    [Header("Sprites")]
    [SerializeField] private List<Sprite> hairBackOptions;
    [SerializeField] private List<Sprite> torsoOptions;
    [SerializeField] private List<Sprite> faceOptions;
    [SerializeField] private List<Sprite> hairOptions;
    [SerializeField] private List<Sprite> eyesOptions;
    [SerializeField] private List<Sprite> mouthOptions;
    [SerializeField] private List<Sprite> noseOptions;
    private int currentHairBack, currentTorso, currentFace, currentHair, currentEyes, currentMouth, currentNose;

    private bool next;

    private string part;

	// Use this for initialization
	void Start () {
        currentHairBack = currentTorso = currentFace = currentHair = currentEyes = currentMouth = currentNose = 0;


        hairBackImage.sprite = current.hairBackSprite;
        torsoImage.sprite = current.torsoSprite;
        faceImage.sprite = current.faceSprite;
        hairImage.sprite = current.hairSprite;
        eyesImage.sprite = current.eyesSprite;
        mouthImage.sprite = current.mouthSprite;
        noseImage.sprite = current.noseSprite;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangePart(string _part)
    {
        part = _part;
    }

    public void ChangeOutfit(bool n)
    {
        next = n;

        switch (part)
        {
            case "hairBack":
                currentHairBack = next ? currentHairBack + 1 : currentHairBack - 1;
                currentHairBack = currentHairBack > hairBackOptions.Capacity - 1 ? currentHairBack - hairBackOptions.Capacity : currentHairBack;
                currentHairBack = currentHairBack < 0 ? hairBackOptions.Capacity - 1 : currentHairBack;
                current.hairBackSprite = hairBackImage.sprite = hairBackOptions[currentHairBack]; 
                break;

            case "torso":
                currentTorso = next ? currentTorso + 1 : currentTorso - 1;
                currentTorso = currentTorso > torsoOptions.Capacity - 1 ? currentTorso - torsoOptions.Capacity : currentTorso;
                currentTorso = currentTorso < 0 ? torsoOptions.Capacity - 1 : currentTorso;
                current.torsoSprite = torsoImage.sprite = torsoOptions[currentTorso];
                break;

            case "face":
                currentFace = next ? currentFace + 1 : currentFace - 1;
                currentFace = currentFace > faceOptions.Capacity - 1 ? currentFace - faceOptions.Capacity : currentFace;
                currentFace = currentFace < 0 ? faceOptions.Capacity - 1 : currentFace;
                current.faceSprite = faceImage.sprite = faceOptions[currentFace];
                break;

            case "hair":
                currentHair = next ? currentHair + 1 : currentHair - 1;
                currentHair = currentHair > hairOptions.Capacity - 1 ? currentHair - hairOptions.Capacity : currentHair;
                currentHair = currentHair < 0 ? hairOptions.Capacity - 1 : currentHair;
                current.hairSprite = hairImage.sprite = hairOptions[currentHair];
                break;

            case "eyes":
                currentEyes = next ? currentEyes + 1 : currentEyes - 1;
                currentEyes = currentEyes > eyesOptions.Capacity - 1 ? currentEyes - eyesOptions.Capacity : currentEyes;
                currentEyes = currentEyes < 0 ? eyesOptions.Capacity - 1 : currentEyes;
                current.eyesSprite = eyesImage.sprite = eyesOptions[currentEyes];
                break;

            case "mouth":
                currentMouth = next ? currentMouth + 1 : currentMouth - 1;
                currentMouth = currentMouth > mouthOptions.Capacity - 1 ? currentMouth - mouthOptions.Capacity : currentMouth;
                currentMouth = currentMouth < 0 ? eyesOptions.Capacity - 1 : currentMouth;
                current.mouthSprite = mouthImage.sprite = mouthOptions[currentMouth];
                break;

            case "nose":
                currentNose = next ? currentNose + 1 : currentNose - 1;
                currentNose = currentNose > noseOptions.Capacity - 1 ? currentNose - noseOptions.Capacity : currentNose;
                currentNose = currentNose < 0 ? noseOptions.Capacity - 1 : currentNose;
                current.noseSprite = noseImage.sprite = noseOptions[currentNose];
                break;
        }
    }
}

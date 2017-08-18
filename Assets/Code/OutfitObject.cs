using UnityEngine;
using System.Collections;

public abstract class OutfitObject : ScriptableObject
{
    public string outfitName = "New Outfit";

    public Sprite hairBackSprite, torsoSprite, faceSprite, hairSprite, eyesSprite, mouthSprite, noseSprite;

    public AudioClip clipSample;
}
using UnityEngine;
using System.Collections;

public abstract class OutfitObject : ScriptableObject
{
    public string outfitName = "New Outfit";

    public Sprite headSprite;
    public Sprite torsoSprite;
    public Sprite legSprite;

    public AudioClip clipSample;
}
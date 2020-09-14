using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationManager : MonoBehaviour
{
    public Sprite[] playerAnimation;
    private int frame = 1;
    public float animationSpeed = 1;
    private float count = 0;


    // Update is called once per frame
    void Update()
    {
        if (count < animationSpeed) count += Time.deltaTime;
        else{
            count = 0;
            if (frame < 6) frame++;
            else frame = 1;
            this.GetComponent<SpriteRenderer>().sprite = playerAnimation[frame-1];
        }
    }
}

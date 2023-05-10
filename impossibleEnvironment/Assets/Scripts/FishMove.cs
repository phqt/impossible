using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMove : MonoBehaviour
{
    //void Start()
    // fish falls into toilet
    // audio plays
    // ui talls player what to do
    // music plays

    // void Update()
    // player must use e to interact and get fish out of toilet flush
    // must consistently press e to save fish
    // bar to fill?
    // bar goes down if player stops pressing e
    // if bar is below 0, lose screen plays > restart button

    // if player fills bar, animation plays?
    
    //time = 19:11

    [SerializeField] Transform topPivot;
    [SerializeField] Transform bottomPivot;

    [SerializeField] Transform fish;
    float fishPosition;
    float fishDestination;

    float fishTimer;

    [SerializeField] float timerMultiplicator = 3f;

    float fishSpeed;
    [SerializeField] float smoothMotion = 1f;

    [SerializeField] Transform hook;
    float hookPosition;
    [SerializeField] float hookSize = 0.1f;
    [SerializeField] float hookPower = 5f;
    float hookProgress;
    float hookPullVelocity;
    [SerializeField] float hookPullPower = 0.01f;
    [SerializeField] float hookGravityPower = 0.005f;
    [SerializeField] float hookProgressFDegradationPower = 0.01f;


    private void Update()
    {
        Fish();
        Hook();
    }

    void Hook()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hookPullVelocity += hookPullPower * Time.deltaTime;

        }
        hookPullVelocity -= hookGravityPower * Time.deltaTime;

        hookPosition += hookPullVelocity;
        hookPosition = Mathf.Clamp(hookPosition, 0, 1);
        hook.position = Vector3.Lerp(bottomPivot.position, topPivot.position, hookPosition);
    }
    void Fish()
    {
        fishTimer -= Time.deltaTime;
        if (fishTimer < 0f)
        {
            fishTimer = UnityEngine.Random.value * timerMultiplicator;

            fishDestination = UnityEngine.Random.value;
        }

        fishPosition = Mathf.SmoothDamp(fishPosition, fishDestination, ref fishSpeed, smoothMotion);
        fish.position = Vector3.Lerp(bottomPivot.position, topPivot.position, fishPosition);
    }
    }


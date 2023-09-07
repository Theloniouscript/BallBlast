using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Destructable))]
public class StoneHitPointsText : MonoBehaviour
{
    [SerializeField] private Text hitpointText;
    private Destructable destructable;

    private void Awake()
    {
        destructable= GetComponent<Destructable>();
        destructable.ChangeHitPoints.AddListener(OnChangeHitPoint);

    }

    private void OnDestroy()
    {
        destructable.ChangeHitPoints.RemoveListener(OnChangeHitPoint);
    }

    private void OnChangeHitPoint()
    {
        int hitPoints = destructable.GetHitPoints();

        if (hitPoints >= 1000) hitpointText.text = hitPoints / 1000 + "K";
        else  hitpointText.text = hitPoints.ToString();
    }
}

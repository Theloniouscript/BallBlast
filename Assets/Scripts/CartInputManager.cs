using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartInputManager : MonoBehaviour
{
    [SerializeField] private Cart cart;

    private void Update()
    {
        cart.SetMovementTarget(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }
}

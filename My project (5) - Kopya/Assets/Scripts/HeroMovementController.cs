using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HeroMovementController : MonoBehaviour
{
    [SerializeField] private HeroInputController heroInputController;

    [SerializeField] private float forwardMovementSpeed;

    [SerializeField] private float horizontalMovementSpeed;

    [SerializeField] private float horizontalLimitValue;

    private float newPositionX;
                                                                                 
                                 
    void FixedUpdate()
    {                                                                  
        SetHeroForwardMovement();
        SetHorizontalMovement();
    }
                              
    private void SetHeroForwardMovement()
    {                                                                                  
        transform.Translate(Vector3.down * forwardMovementSpeed * Time.fixedDeltaTime);
    }                                                                                                             

    private void SetHorizontalMovement()                   
    {
      newPositionX = transform.position.x + heroInputController.horizontalValue * horizontalMovementSpeed * Time.fixedDeltaTime;
        newPositionX = Mathf.Clamp(newPositionX, -horizontalLimitValue, horizontalLimitValue);
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }
    
}

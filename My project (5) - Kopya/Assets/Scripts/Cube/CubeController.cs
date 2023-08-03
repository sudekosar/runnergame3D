using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private HeroStackController heroStackController;
    private Vector3 direction = Vector3.back;

    private bool isStack = false;
    void Start()
    {
        heroStackController = GameObject.FindObjectOfType<HeroStackController>();
    }

    
    void FixedUpdate()
    {
        SetCubeRaycast();
    }

    private void SetCubeRaycast()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, direction, out hit, 1f))
        {
            if (!isStack)
            { 
                isStack = true;
                heroStackController.IncreaseBlockStack(gameObject);

            }
        }


    }
}

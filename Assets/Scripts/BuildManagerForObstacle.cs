using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManagerForObstacle : MonoBehaviour
{
    private GameObject obstacleBlock;
    private GameObject pendingObject;
    private Vector3 pos;
    private int obstacleBlockCost = 5000;

    private RaycastHit hit;
    [SerializeField] private LayerMask layerMask;

    void Update()
    {
        if(pendingObject != null)
        {
            pendingObject.transform.position = pos;

            if (Input.GetMouseButtonDown(0))
            {              

                PlayerStats.Money -= obstacleBlockCost;
                PlaceObject();
            }

            if (Input.GetMouseButtonDown(1))
            {
                Destroy(pendingObject);
            }
        }
    }

    public void PlaceObject()
    {
        pendingObject = null;
    }

    private void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit, 1000, layerMask))
        {
            pos = hit.point;
        }
    }

    public void SelectObject(GameObject obstacleBlock)
    {
        //if(BuildManager.instance != null)
        //{
        //    BuildManager.instance = null;
        //}
        BuildManager.Terminate();
            
        if (PlayerStats.Money < obstacleBlockCost)
        {
            pendingObject = null;
            Debug.Log("Not enough money to build that!");
            return;
        }

        if (WaveSpawner.EnemiesAlive > 0)
        {
            pendingObject = null;
            Debug.Log("You can only build obstacles if there is no enemy alive!");
            return;
        }

        pendingObject = Instantiate(obstacleBlock, pos, transform.rotation);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainBuilding : MonoBehaviour
{
    void OnMouseOver()
    {
        Debug.Log("Mouse is over Empty Spot.");
        if (Input.GetMouseButtonDown(0))
        {
            print(BuildingManager.Instance.myBuildingsList);
            Instantiate(BuildingManager.Instance.myBuildingsList[0], transform.position, transform.rotation);
            BuildingManager.Instance.myBuildingsList.RemoveAt(0);
        }
    }
    void OnMouseExit()
    {
        
        Debug.Log("Mouse is no longer on GameObject.");
    }
}

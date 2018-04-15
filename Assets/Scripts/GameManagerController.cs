using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerController : MonoBehaviour
{
  public GameObject towerPrefab;

  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  public void HandlePlayerAction(PlayerAction action)
  {
    Instantiate(towerPrefab, action.ray.GetPoint(49), Quaternion.identity);
  }
}

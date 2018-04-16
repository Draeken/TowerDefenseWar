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
    RaycastHit2D hit = Physics2D.Raycast(action.ray.GetPoint(0), Vector2.zero, 60);
    if (hit.collider != null)
    {
      Destroy(hit.collider.gameObject);
    }
    else
    {
      Instantiate(towerPrefab, action.ray.GetPoint(49), Quaternion.identity);
    }
  }
}

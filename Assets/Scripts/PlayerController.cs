using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public GameObject towerPrefab;

  private new Camera camera;
  // Use this for initialization
  void Start()
  {
    camera = GetComponent<Camera>();
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      Ray rayCast = camera.ScreenPointToRay(Input.mousePosition);
      var tower = Instantiate(towerPrefab, rayCast.GetPoint(49), Quaternion.identity);
    }
  }
}

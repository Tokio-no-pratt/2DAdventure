using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
     float horizontal = 1.0f;
  public InputAction LeftAction;
  public InputAction MoveAction;
  


   //Start is called before the first frame update
  void Start()
  {
     MoveAction.Enable();   
  }
 
  // Update is called once per frame
void Update()
{
    Vector2 move = MoveAction.ReadValue<Vector2>();
    Debug.Log(move);

    Vector3 movement = new Vector3(move.x, move.y, 0f);
    transform.position += movement * 5.1f * Time.deltaTime;
    Debug.Log($"Horizontal: {move.x} | Vertical: {move.y}");

}

}

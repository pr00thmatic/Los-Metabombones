using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
  public event System.Action onThrowBallRequested;

  [Header("Configuration")]
  public float speed;
  public int lives;

  [Header("Information")]
  public Vector3 motionSpeed;
  public Vector3 ballThrowDirection;
  public bool useGamepad = false;

  [Header("Initialization")]
  public Rigidbody body;
  public Transform viewport;

  void Reset () {
    body = GetComponent<Rigidbody>();
    viewport = Camera.main.transform.parent;
  }

  void Start () {
    ballThrowDirection = transform.forward;
    lives = 5;
  }

  void OnEnable () {
    InputManager.Player.Fire.performed += ctx => onThrowBallRequested?.Invoke();
    InputManager.Player.GamepadUseIndicator.performed += ctx => useGamepad = true;
    InputManager.Player.KeyboardUseIndicator.performed += ctx => useGamepad = false;
  }

  void FixedUpdate () {
    motionSpeed = (viewport.right * InputManager.Player.Motion.ReadValue<Vector2>().x +
                   viewport.forward * InputManager.Player.Motion.ReadValue<Vector2>().y) * speed;
    body.MovePosition(transform.position + motionSpeed * Time.deltaTime);

    Vector3 target;
    if (useGamepad) {
      target = viewport.right * InputManager.Player.JoystickAim.ReadValue<Vector2>().x +
        viewport.forward * InputManager.Player.JoystickAim.ReadValue<Vector2>().y;
    } else {
      target = InputManager.Player.MouseAim.ReadValue<Vector2>();
      Ray ray = Camera.main.ScreenPointToRay(target);
      float distance;
      (new Plane(Vector3.up, transform.position)).Raycast(Camera.main.ScreenPointToRay(target), out distance);
      target = (ray.GetPoint(distance) - transform.position).normalized;
    }
    if (target != Vector3.zero) {
      ballThrowDirection = target;
    }
  }
}

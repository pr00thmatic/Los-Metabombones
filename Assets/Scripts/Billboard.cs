using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour {
  public static float min = 1.5f;
  public static float max = 1.1f;
  public static float minDistance = 12.3f;
  public static float maxDistance = 34.7f;

  void Update () {
    Vector3 d = Camera.main.transform.position - transform.position;
    transform.forward = Vector3.Scale(new Vector3(1,0,1), d);
    Vector3 s = transform.localScale;
    s.y = Mathf.Lerp(min, max, (d.magnitude - minDistance) / (maxDistance - minDistance));
    transform.localScale = s;
  }
}

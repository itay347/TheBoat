using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StretchScript : MonoBehaviour {

    public float orthographicSize = 4;
    public float aspect = 0.6f;

    void Start()
    {
        Camera.main.projectionMatrix = Matrix4x4.Ortho(
                -orthographicSize * aspect, orthographicSize * aspect,
                -orthographicSize, orthographicSize,
                Camera.main.nearClipPlane, Camera.main.farClipPlane);
    }

}

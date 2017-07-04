using UnityEngine;

// Source: http://answers.unity3d.com/questions/464487/windowed-game-to-fullscreen.html
public class StretchScript : MonoBehaviour {

    public float orthographicSize = 4;
    public float aspect = 0.6f;

#if UNITY_ANDROID
    void Start()
    {
        Camera.main.projectionMatrix = Matrix4x4.Ortho(
                -orthographicSize * aspect, orthographicSize * aspect,
                -orthographicSize, orthographicSize,
                Camera.main.nearClipPlane, Camera.main.farClipPlane);
    }
#endif
}

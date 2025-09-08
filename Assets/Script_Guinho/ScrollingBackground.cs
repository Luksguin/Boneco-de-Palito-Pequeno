using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class ScrollingBackground : MonoBehaviour
{
    public float speed;
    public Material myMaterial;

    private float _delta = 0;

    private void Update()
    {
        _delta += speed * Time.deltaTime;
        myMaterial.mainTextureOffset = new Vector2(_delta, 0);
    }
}

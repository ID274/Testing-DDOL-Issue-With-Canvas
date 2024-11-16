using UnityEngine;

public class FindCamera : MonoBehaviour
{
    [SerializeField] private Canvas canvas;

    private void Awake()
    {
        canvas = GetComponent<Canvas>();

    }

    public void AssignCamera()
    {
        canvas.worldCamera = Camera.main;
    }
}

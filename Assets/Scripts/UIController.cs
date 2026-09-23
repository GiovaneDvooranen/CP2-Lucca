using UnityEngine;
using Vuforia;

public class UIController : MonoBehaviour
{
    public GameObject canvas;

    void Start()
    {
        canvas.SetActive(false);
    }

    public void OnTargetFound()
    {
        canvas.SetActive(true);
    }

    public void OnTargetLost()
    {
        canvas.SetActive(false);
    }
}

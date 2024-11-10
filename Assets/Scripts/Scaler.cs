using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _increaseSpeed;

    private void Update()
    {
        transform.localScale += Vector3.one * (_increaseSpeed * Time.deltaTime);
    }
}

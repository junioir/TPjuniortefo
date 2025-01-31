using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Vector3 initialPosition;
    private Vector3 openPosition;
    private bool isOpening;

    [SerializeField] private float openDistance = 3f;
    [SerializeField] private float openSpeed = 2f;

    private void Start()
    {
        initialPosition = transform.position;
        openPosition = initialPosition + Vector3.up * openDistance;
    }

    public void SetDoorState(bool open)
    {
        isOpening = open;
        StopAllCoroutines();
        StartCoroutine(MoveDoor());
    }

    private System.Collections.IEnumerator MoveDoor()
    {
        Vector3 targetPosition = isOpening ? openPosition : initialPosition;
        while (Vector3.Distance(transform.position, targetPosition) > 0.01f)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, openSpeed * Time.deltaTime);
            yield return null;
        }
        transform.position = targetPosition;
    }
}

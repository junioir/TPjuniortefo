using UnityEngine;

public class TileTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TileEventManager.TilePressed();
        }
    }
}

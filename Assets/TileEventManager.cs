using UnityEngine;
using UnityEngine.Events;

public class TileEventManager : MonoBehaviour
{
    public static UnityEvent OnTilePressed = new UnityEvent();

    public static void TilePressed()
    {
        OnTilePressed.Invoke();
    }
}

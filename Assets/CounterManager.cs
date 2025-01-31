using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CounterManager : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    private int counter = 0;

    private void OnEnable()
    {
        TileEventManager.OnTilePressed.AddListener(IncrementCounter);
    }

    private void OnDisable()
    {
        TileEventManager.OnTilePressed.RemoveListener(IncrementCounter);
    }

    private void IncrementCounter()
    {
        counter++;
        counterText.text = counter.ToString();
    }
}

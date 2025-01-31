using UnityEngine;
using UnityEngine.UI;

public class ProgressBarManager : MonoBehaviour
{
    public Slider progressBar;
    private float progress = 0f;

    private void OnEnable()
    {
        TileEventManager.OnTilePressed.AddListener(UpdateProgressBar);
    }

    private void OnDisable()
    {
        TileEventManager.OnTilePressed.RemoveListener(UpdateProgressBar);
    }

    private void UpdateProgressBar()
    {
        progress += 0.1f; // Ajustez l'incrément selon vos besoins
        progressBar.value = Mathf.Clamp01(progress);
    }
}

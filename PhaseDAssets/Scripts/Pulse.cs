using UnityEngine;

public class Pulse : MonoBehaviour
{
    public float initialScale = 300f;
    public float targetScale = 450f;
    public float pulseSpeed = 100f;
    private float _currentScale;

    public GameObject Psyche;

    void Start()
    {
        _currentScale = initialScale;
    }

    void Update()
    {
        
    }

    public void Pulser()
    {
        _currentScale = Mathf.Lerp(_currentScale, targetScale, pulseSpeed * Time.deltaTime);
        transform.localScale = new Vector3(_currentScale, _currentScale, 1);

        targetScale += 75f;
    }

    public void UpDown()
    {
        float scale = Mathf.Lerp(initialScale, targetScale, (Mathf.Sin(Time.time * pulseSpeed) + 1f) / 2f);
        transform.localScale = new Vector3(scale, scale, 1);
    }
}

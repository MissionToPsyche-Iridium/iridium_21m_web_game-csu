using UnityEngine;
using UnityEngine.UI;

public class Shake : MonoBehaviour
{
    public float Duration = 5f;
    public float Mag;
    public GameObject Psyche;
    public GameObject popup;

    private float Timer;
    private Vector3 originalPosition;

    void Start()
    {
        originalPosition = Psyche.transform.position;
    }

    void Update()
    {
        if (Timer > 0)
        {
            Timer -= Time.deltaTime;
            Vector3 randomOffset = Random.insideUnitSphere * Mag;
            Psyche.transform.position = originalPosition + randomOffset;
        }
        else
        {
            Psyche.transform.position = originalPosition;
        }

        if (popup.activeInHierarchy == true){
            Psyche.transform.position = originalPosition;
        }
    }

    public void HighShake()
    {
        Timer = Duration;
        Mag = 5.0f;
    }

    public void MedShake()
    {
        Timer = Duration;
        Mag = 1.0f;
    }

    public void LowShake()
    {
        Timer = Duration;
        Mag = 0.2f;
    }
}

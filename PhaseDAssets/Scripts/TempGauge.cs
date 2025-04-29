using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TempGauge : MonoBehaviour
{
    [SerializeField] private TMP_Text temp;
    [SerializeField] private int tempValue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tempValue = 15;
        temp.text = "15°C";
    }

    void Update()
    {
       
    }
    public void RaiseTemp()
    {
        tempValue += 3;
        temp.text = tempValue + "°C";
    }

    public void LowerTemp()
    {
        tempValue -= 3;
        temp.text = tempValue + "°C";
    }
}

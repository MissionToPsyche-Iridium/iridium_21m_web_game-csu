using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TempGauge : MonoBehaviour
{
    [SerializeField] private TMP_Text temp;
    [SerializeField] private int tempValue;
    void Start()
    {
        tempValue = 15;
        temp.text = "15°C";
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

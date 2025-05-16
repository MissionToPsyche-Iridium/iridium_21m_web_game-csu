using UnityEngine;
using UnityEngine.UI;

public class Glow : MonoBehaviour
{
    public Image redOverlay;
    public Image blueOverlay;
    public float alphaR, alphaB;
    public int temp = 10;

    private void Start()
    {
        alphaR = 0f;
        alphaB = 0f;
        redOverlay.color = new Color(1f, 0f, 0f, alphaR);
        blueOverlay.color = new Color(0f, 0f, 1f, alphaB);
    }

    public void UpdateColor()
    {
        switch (temp)
        {
            case 0:
                alphaR = 0f;
                alphaB = 0f;
                redOverlay.color = new Color(1f, 0f, 0f, alphaR);
                blueOverlay.color = new Color(0f, 0f, 1f, alphaB);
                break;
            case 1:
                alphaR = 0f;
                alphaB = 0.18f;
                redOverlay.color = new Color(1f, 0f, 0f, alphaR);
                blueOverlay.color = new Color(0f, 0f, 1f, alphaB);
                break;
            case 2:
                alphaR = 0f;
                alphaB = 0.16f;
                redOverlay.color = new Color(1f, 0f, 0f, alphaR);
                blueOverlay.color = new Color(0f, 0f, 1f, alphaB);
                break;
            case 3:
                alphaR = 0f;
                alphaB = 0.14f;
                redOverlay.color = new Color(1f, 0f, 0f, alphaR);
                blueOverlay.color = new Color(0f, 0f, 1f, alphaB);
                break;
            case 4:
                alphaR = 0f;
                alphaB = 0.12f;
                redOverlay.color = new Color(1f, 0f, 0f, alphaR);
                blueOverlay.color = new Color(0f, 0f, 1f, alphaB);
                break;
            case 5:
                alphaR = 0f;
                alphaB = 0.1f;
                redOverlay.color = new Color(1f, 0f, 0f, alphaR);
                blueOverlay.color = new Color(0f, 0f, 1f, alphaB);
                break;
            case 6:
                alphaR = 0f;
                alphaB = 0.08f;
                redOverlay.color = new Color(1f, 0f, 0f, alphaR);
                blueOverlay.color = new Color(0f, 0f, 1f, alphaB);
                break;
            case 7:
                alphaR = 0f;
                alphaB = 0.06f;
                redOverlay.color = new Color(1f, 0f, 0f, alphaR);
                blueOverlay.color = new Color(0f, 0f, 1f, alphaB);
                break;
            case 8:
                alphaR = 0f;
                alphaB = 0.04f;
                redOverlay.color = new Color(1f, 0f, 0f, alphaR);
                blueOverlay.color = new Color(0f, 0f, 1f, alphaB);
                break;
            case 9:
                alphaR = 0f;
                alphaB = 0.02f;
                redOverlay.color = new Color(1f, 0f, 0f, alphaR);
                blueOverlay.color = new Color(0f, 0f, 1f, alphaB);
                break;
            case 10:
                alphaR = 0f;
                alphaB = 0f;
                redOverlay.color = new Color(1f, 0f, 0f, alphaR);
                blueOverlay.color = new Color(0f, 0f, 1f, alphaB);
                break;
            case 11:
                alphaR = 0.02f;
                alphaB = 0f;
                redOverlay.color = new Color(1f, 0f, 0f, alphaR);
                blueOverlay.color = new Color(0f, 0f, 1f, alphaB);
                break;
            case 12:
                alphaR = 0.04f;
                alphaB = 0f;
                redOverlay.color = new Color(1f, 0f, 0f, alphaR);
                blueOverlay.color = new Color(0f, 0f, 1f, alphaB);
                break;
            case 13:
                alphaR = 0.06f;
                alphaB = 0f;
                redOverlay.color = new Color(1f, 0f, 0f, alphaR);
                blueOverlay.color = new Color(0f, 0f, 1f, alphaB);
                break;
            case 14:
                alphaR = 0.08f;
                alphaB = 0f;
                redOverlay.color = new Color(1f, 0f, 0f, alphaR);
                blueOverlay.color = new Color(0f, 0f, 1f, alphaB);
                break;
            case 15:
                alphaR = 0.1f;
                alphaB = 0f;
                redOverlay.color = new Color(1f, 0f, 0f, alphaR);
                blueOverlay.color = new Color(0f, 0f, 1f, alphaB);
                break;
            case 16:
                alphaR = 0.12f;
                alphaB = 0f;
                redOverlay.color = new Color(1f, 0f, 0f, alphaR);
                blueOverlay.color = new Color(0f, 0f, 1f, alphaB);
                break;
            case 17:
                alphaR = 0.14f;
                alphaB = 0f;
                redOverlay.color = new Color(1f, 0f, 0f, alphaR);
                blueOverlay.color = new Color(0f, 0f, 1f, alphaB);
                break;
            case 18:
                alphaR = 0.16f;
                alphaB = 0f;
                redOverlay.color = new Color(1f, 0f, 0f, alphaR);
                blueOverlay.color = new Color(0f, 0f, 1f, alphaB);
                break;
            case 19:
                alphaR = 0.18f;
                alphaB = 0f;
                redOverlay.color = new Color(1f, 0f, 0f, alphaR);
                blueOverlay.color = new Color(0f, 0f, 1f, alphaB);
                break;
            case 20:
                alphaR = 0f;
                alphaB = 0f;
                redOverlay.color = new Color(1f, 0f, 0f, alphaR);
                blueOverlay.color = new Color(0f, 0f, 1f, alphaB);
                break;
            default:
                break;
        }
    }

    public void Raise()
    {
        temp += 1;
        UpdateColor();
    }

    public void Lower()
    {
        temp -= 1;
        UpdateColor();
    }
}

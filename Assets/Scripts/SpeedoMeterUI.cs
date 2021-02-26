using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedoMeterUI : MonoBehaviour
{
    [Range(0,1)]
    public float value;
    [Range(1, 360)]
    public float fullAngle = 180;

    public RectTransform hand;
    [Range(1, 360)]
    public float startAngle = 1;

    // Update is called once per frame
    void Update()
    {
        ReCalculatePosition();
    }

    private void ReCalculatePosition()
    {
        float valueoptimize = value * Mathf.PI * (fullAngle/180);
        float x = Mathf.Cos(valueoptimize);
        float y = Mathf.Sin(valueoptimize);
        float anglez = Mathf.Atan2(x, y) * Mathf.Rad2Deg;
        hand.rotation = Quaternion.Lerp(hand.rotation, Quaternion.Euler(0, 0,(startAngle+anglez)-90), 0.05f);
    }
}

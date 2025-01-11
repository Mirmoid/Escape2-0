using UnityEngine;

public class TurnOnOff : MonoBehaviour
{
    public Light flashlight;
    public float intensity;

    private void Start()
    {
        flashlight = GetComponent<Light>();
    }
    private void Update()
    {
         if (flashlight.intensity == 7)
         {
                if (Input.GetMouseButtonUp(0))
                {
                    flashlight.intensity -= 7;
                }
         }

        if (flashlight.intensity == 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                flashlight.intensity += 7;
            }
        }
    }
}

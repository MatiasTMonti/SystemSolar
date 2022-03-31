using UnityEngine;
using TMPro;

public class Camera : MonoBehaviour
{
    private int num = 0;

    [SerializeField] private GameObject worldCamera;
    [SerializeField] private GameObject sunCamera;
    [SerializeField] private GameObject mercuryCamera;
    [SerializeField] private GameObject venusCamera;
    [SerializeField] private GameObject earthCamera;
    [SerializeField] private GameObject marsCamera;
    [SerializeField] private GameObject jupiterCamera;
    [SerializeField] private GameObject saturnCamera;
    [SerializeField] private GameObject UranusCamera;
    [SerializeField] private GameObject NeptuneCamera;

    [SerializeField] private GameObject worldLight;

    [SerializeField] private Transform mercury;
    [SerializeField] private Transform venus;
    [SerializeField] private Transform earth;
    [SerializeField] private Transform mars;
    [SerializeField] private Transform jupiter;
    [SerializeField] private Transform saturn;
    [SerializeField] private Transform uranus;
    [SerializeField] private Transform neptune;

    [SerializeField] private Transform mercuryCameraTransform;
    [SerializeField] private Transform venusCameraTransform;
    [SerializeField] private Transform earthCameraTransform;
    [SerializeField] private Transform marsCameraTransform;
    [SerializeField] private Transform jupiterCameraTransform;
    [SerializeField] private Transform saturnCameraTransform;
    [SerializeField] private Transform uranusCameraTransform;
    [SerializeField] private Transform NeptuneCameraTransform;

    [SerializeField] private TextMeshPro sunText;
    [SerializeField] private TextMeshPro mercuryText;
    [SerializeField] private TextMeshPro venusText;
    [SerializeField] private TextMeshPro earthText;
    [SerializeField] private TextMeshPro marsText;
    [SerializeField] private TextMeshPro jupiterText;
    [SerializeField] private TextMeshPro saturnText;
    [SerializeField] private TextMeshPro uranusText;
    [SerializeField] private TextMeshPro neptuneText;
    [SerializeField] private TextMeshPro galaxyText;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            num++;
            if (num > 9)
            {
                num = 0;
            }
            Debug.Log(num);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            num--;
            if (num < 0)
            {
                num = 9;
            }
            Debug.Log(num);
        }

        mercuryCameraTransform.position = mercury.position + new Vector3(0, 0, -2);
        venusCameraTransform.position = venus.position + new Vector3(0, 0, -2);
        earthCameraTransform.position = earth.position + new Vector3(0, 0, -2);
        marsCameraTransform.position = mars.position + new Vector3(0, 0, -2);
        jupiterCameraTransform.position = jupiter.position + new Vector3(0, 0, -4);
        saturnCameraTransform.position = saturn.position + new Vector3(0, 0, -4);
        uranusCameraTransform.position = uranus.position + new Vector3(0, 0, -3);
        NeptuneCameraTransform.position = neptune.position + new Vector3(0, 0, -3);

        mercuryText.transform.position = mercury.position + new Vector3(8, -2, 0);
        venusText.transform.position = venus.position + new Vector3(7, -1.4f, 0);
        earthText.transform.position = earth.position + new Vector3(-10.95f, -1.8f, 0);
        marsText.transform.position = mars.position + new Vector3(-8.95f, -1.8f, 0);
        jupiterText.transform.position = jupiter.position + new Vector3(-11, -2f, 0);
        saturnText.transform.position = saturn.position + new Vector3(-10.3f, -2f, -2);
        uranusText.transform.position = uranus.position + new Vector3(-9.75f, -1.8f, -1);
        neptuneText.transform.position = neptune.position + new Vector3(-10.3f, -1.8f, -1);

        switch (num)
        {
            case 0:
                worldCamera.SetActive(true);
                sunCamera.SetActive(false);
                mercuryCamera.SetActive(false);
                venusCamera.SetActive(false);
                earthCamera.SetActive(false);
                marsCamera.SetActive(false);
                jupiterCamera.SetActive(false);
                saturnCamera.SetActive(false);
                UranusCamera.SetActive(false);
                NeptuneCamera.SetActive(false);

                sunText.gameObject.SetActive(false);
                mercuryText.gameObject.SetActive(false);
                venusText.gameObject.SetActive(false);
                earthText.gameObject.SetActive(false);
                marsText.gameObject.SetActive(false);
                jupiterText.gameObject.SetActive(false);
                saturnText.gameObject.SetActive(false);
                uranusText.gameObject.SetActive(false);
                neptuneText.gameObject.SetActive(false);

                galaxyText.gameObject.SetActive(true);
                sunText.gameObject.SetActive(false);
                mercuryText.gameObject.SetActive(false);
                venusText.gameObject.SetActive(false);
                earthText.gameObject.SetActive(false);
                marsText.gameObject.SetActive(false);
                jupiterText.gameObject.SetActive(false);
                saturnText.gameObject.SetActive(false);
                uranusText.gameObject.SetActive(false);
                neptuneText.gameObject.SetActive(false);

                worldLight.SetActive(false);
                break;
            case 1:
                worldCamera.SetActive(false);
                sunCamera.SetActive(true);
                mercuryCamera.SetActive(false);
                venusCamera.SetActive(false);
                earthCamera.SetActive(false);
                marsCamera.SetActive(false);
                jupiterCamera.SetActive(false);
                saturnCamera.SetActive(false);
                UranusCamera.SetActive(false);
                NeptuneCamera.SetActive(false);

                galaxyText.gameObject.SetActive(false);
                sunText.gameObject.SetActive(true);
                mercuryText.gameObject.SetActive(false);
                venusText.gameObject.SetActive(false);
                earthText.gameObject.SetActive(false);
                marsText.gameObject.SetActive(false);
                jupiterText.gameObject.SetActive(false);
                saturnText.gameObject.SetActive(false);
                uranusText.gameObject.SetActive(false);
                neptuneText.gameObject.SetActive(false);

                worldLight.SetActive(true);
                break;
            case 2:
                worldCamera.SetActive(false);
                sunCamera.SetActive(false);
                mercuryCamera.SetActive(true);
                venusCamera.SetActive(false);
                earthCamera.SetActive(false);
                marsCamera.SetActive(false);
                jupiterCamera.SetActive(false);
                saturnCamera.SetActive(false);
                UranusCamera.SetActive(false);
                NeptuneCamera.SetActive(false);

                galaxyText.gameObject.SetActive(false);
                sunText.gameObject.SetActive(false);
                mercuryText.gameObject.SetActive(true);
                venusText.gameObject.SetActive(false);
                earthText.gameObject.SetActive(false);
                marsText.gameObject.SetActive(false);
                jupiterText.gameObject.SetActive(false);
                saturnText.gameObject.SetActive(false);
                uranusText.gameObject.SetActive(false);
                neptuneText.gameObject.SetActive(false);

                worldLight.SetActive(true);
                break;
            case 3:
                worldCamera.SetActive(false);
                sunCamera.SetActive(false);
                mercuryCamera.SetActive(false);
                venusCamera.SetActive(true);
                earthCamera.SetActive(false);
                marsCamera.SetActive(false);
                jupiterCamera.SetActive(false);
                saturnCamera.SetActive(false);
                UranusCamera.SetActive(false);
                NeptuneCamera.SetActive(false);

                galaxyText.gameObject.SetActive(false);
                sunText.gameObject.SetActive(false);
                mercuryText.gameObject.SetActive(false);
                venusText.gameObject.SetActive(true);
                earthText.gameObject.SetActive(false);
                marsText.gameObject.SetActive(false);
                jupiterText.gameObject.SetActive(false);
                saturnText.gameObject.SetActive(false);
                uranusText.gameObject.SetActive(false);
                neptuneText.gameObject.SetActive(false);

                worldLight.SetActive(true);
                break;
            case 4:
                worldCamera.SetActive(false);
                sunCamera.SetActive(false);
                mercuryCamera.SetActive(false);
                venusCamera.SetActive(false);
                earthCamera.SetActive(true);
                marsCamera.SetActive(false);
                jupiterCamera.SetActive(false);
                saturnCamera.SetActive(false);
                UranusCamera.SetActive(false);
                NeptuneCamera.SetActive(false);

                galaxyText.gameObject.SetActive(false);
                sunText.gameObject.SetActive(false);
                mercuryText.gameObject.SetActive(false);
                venusText.gameObject.SetActive(false);
                earthText.gameObject.SetActive(true);
                marsText.gameObject.SetActive(false);
                jupiterText.gameObject.SetActive(false);
                saturnText.gameObject.SetActive(false);
                uranusText.gameObject.SetActive(false);
                neptuneText.gameObject.SetActive(false);

                worldLight.SetActive(true);
                break;
            case 5:
                worldCamera.SetActive(false);
                sunCamera.SetActive(false);
                mercuryCamera.SetActive(false);
                venusCamera.SetActive(false);
                earthCamera.SetActive(false);
                marsCamera.SetActive(true);
                jupiterCamera.SetActive(false);
                saturnCamera.SetActive(false);
                UranusCamera.SetActive(false);
                NeptuneCamera.SetActive(false);

                galaxyText.gameObject.SetActive(false);
                sunText.gameObject.SetActive(false);
                mercuryText.gameObject.SetActive(false);
                venusText.gameObject.SetActive(false);
                earthText.gameObject.SetActive(false);
                marsText.gameObject.SetActive(true);
                jupiterText.gameObject.SetActive(false);
                saturnText.gameObject.SetActive(false);
                uranusText.gameObject.SetActive(false);
                neptuneText.gameObject.SetActive(false);

                worldLight.SetActive(true);
                break;
            case 6:
                worldCamera.SetActive(false);
                sunCamera.SetActive(false);
                mercuryCamera.SetActive(false);
                venusCamera.SetActive(false);
                earthCamera.SetActive(false);
                marsCamera.SetActive(false);
                jupiterCamera.SetActive(true);
                saturnCamera.SetActive(false);
                UranusCamera.SetActive(false);
                NeptuneCamera.SetActive(false);

                galaxyText.gameObject.SetActive(false);
                sunText.gameObject.SetActive(false);
                mercuryText.gameObject.SetActive(false);
                venusText.gameObject.SetActive(false);
                earthText.gameObject.SetActive(false);
                marsText.gameObject.SetActive(false);
                jupiterText.gameObject.SetActive(true);
                saturnText.gameObject.SetActive(false);
                uranusText.gameObject.SetActive(false);
                neptuneText.gameObject.SetActive(false);

                worldLight.SetActive(true);
                break;
            case 7:
                worldCamera.SetActive(false);
                sunCamera.SetActive(false);
                mercuryCamera.SetActive(false);
                venusCamera.SetActive(false);
                earthCamera.SetActive(false);
                marsCamera.SetActive(false);
                jupiterCamera.SetActive(false);
                saturnCamera.SetActive(true);
                UranusCamera.SetActive(false);
                NeptuneCamera.SetActive(false);

                galaxyText.gameObject.SetActive(false);
                sunText.gameObject.SetActive(false);
                mercuryText.gameObject.SetActive(false);
                venusText.gameObject.SetActive(false);
                earthText.gameObject.SetActive(false);
                marsText.gameObject.SetActive(false);
                jupiterText.gameObject.SetActive(false);
                saturnText.gameObject.SetActive(true);
                uranusText.gameObject.SetActive(false);
                neptuneText.gameObject.SetActive(false);

                worldLight.SetActive(true);
                break;
            case 8:
                worldCamera.SetActive(false);
                sunCamera.SetActive(false);
                mercuryCamera.SetActive(false);
                venusCamera.SetActive(false);
                earthCamera.SetActive(false);
                marsCamera.SetActive(false);
                jupiterCamera.SetActive(false);
                saturnCamera.SetActive(false);
                UranusCamera.SetActive(true);
                NeptuneCamera.SetActive(false);

                galaxyText.gameObject.SetActive(false);
                sunText.gameObject.SetActive(false);
                mercuryText.gameObject.SetActive(false);
                venusText.gameObject.SetActive(false);
                earthText.gameObject.SetActive(false);
                marsText.gameObject.SetActive(false);
                jupiterText.gameObject.SetActive(false);
                saturnText.gameObject.SetActive(false);
                uranusText.gameObject.SetActive(true);
                neptuneText.gameObject.SetActive(false);

                worldLight.SetActive(true);
                break;
            case 9:
                worldCamera.SetActive(false);
                sunCamera.SetActive(false);
                mercuryCamera.SetActive(false);
                venusCamera.SetActive(false);
                earthCamera.SetActive(false);
                marsCamera.SetActive(false);
                jupiterCamera.SetActive(false);
                saturnCamera.SetActive(false);
                UranusCamera.SetActive(false);
                NeptuneCamera.SetActive(true);

                galaxyText.gameObject.SetActive(false);
                sunText.gameObject.SetActive(false);
                mercuryText.gameObject.SetActive(false);
                venusText.gameObject.SetActive(false);
                earthText.gameObject.SetActive(false);
                marsText.gameObject.SetActive(false);
                jupiterText.gameObject.SetActive(false);
                saturnText.gameObject.SetActive(false);
                uranusText.gameObject.SetActive(false);
                neptuneText.gameObject.SetActive(true);

                worldLight.SetActive(true);
                break;
            default:
                break;
        }
    }
}

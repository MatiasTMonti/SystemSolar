using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
                break;
            default:
                break;
        }
    }
}

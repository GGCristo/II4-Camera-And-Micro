using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button : MonoBehaviour
{
    public Button button_;
    // Start is called before the first frame update
    void Start()
    {
        button_ = GetComponent<Button>();
        button_.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TaskOnClick()
    {
        if (cameraClass.isPaused) {
            cameraClass.cameraTexture.Play();
        } else {
            cameraClass.cameraTexture.Pause();
        }
        cameraClass.isPaused = !cameraClass.isPaused;
    }

}

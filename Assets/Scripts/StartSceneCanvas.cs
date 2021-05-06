using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartSceneCanvas : MonoBehaviour
{

    [SerializeField] [Range(1, 50)] int headerFontSize = 27;

    void Start()
    {
        var headerSize = GetComponent<TextMesh>().fontSize = headerFontSize;
    }

    
    void Update()
    {
        
    }
}

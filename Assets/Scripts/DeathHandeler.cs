using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandeler : MonoBehaviour
{
    [SerializeField] Canvas deathCanvas;
    // Start is called before the first frame update
    void Start()
    {
        deathCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HandelDeath()
    {
        deathCanvas.enabled = true;
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }
}

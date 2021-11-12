using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private SettingsPopup popup; // ссылаемся на всплывающее окно в сцене

    // Start is called before the first frame update
    void Start()
    {
        popup.gameObject.SetActive(false); // инициализируем в скрытом состоянии   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M)) { // вызываем всплывающее окно при помощии клавиши M
            bool isShowing = popup.gameObject.activeSelf;
            popup.gameObject.SetActive(!isShowing);

            if (isShowing) { // вместе со всплывающим окном вызываем курсор
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            } else {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }
}

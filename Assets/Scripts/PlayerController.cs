using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Transform _rotator;

    private float currentHealth = 100f;
    private float currentStamina = 100f;

    private float maxStamina = 100f;
    private float maxHealth = 100f;


    public Image healthBar;
    public Image staminaBar;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = 0.5f;
/*        float test = this.staminaBar.rectTransform.sizeDelta.y;
        this.staminaBar.rectTransform.sizeDelta = new Vector2(100f, test);
        this.staminaBar.rectTransform.right = new Vector2(100f, test);*/

        _rotator = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {/*
        _rotator.position = new Vector3(_rotator.position.x + 10f * Time.deltaTime, _rotator.position.y, _rotator.position.z);
        _rotator.Rotate(0, speed * Time.deltaTime, 0);*/
    }
}
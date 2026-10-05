using UnityEngine;
using UnityEngine.InputSystem;

public class UcakHareket : MonoBehaviour
{
    [SerializeField] private float hareketHizi = 5f;
    [SerializeField] private float ileriGeriHizi = 5f;

    void Update()
    {
        float yatay = 0f;
        float ileriGeri = 0f;

        // SOL
        if (Keyboard.current.aKey.isPressed ||
            Keyboard.current.leftArrowKey.isPressed)
        {
            yatay = -1f;
        }

        // SAÐ
        if (Keyboard.current.dKey.isPressed ||
            Keyboard.current.rightArrowKey.isPressed)
        {
            yatay = 1f;
        }

        // ÝLERÝ - E
        if (Keyboard.current.eKey.isPressed)
        {
            ileriGeri = 1f;
        }

        // GERÝ - Z
        if (Keyboard.current.zKey.isPressed)
        {
            ileriGeri = -1f;
        }

        // Saða - sola hareket
        transform.Translate(
            Vector3.right * yatay * hareketHizi * Time.deltaTime,
            Space.World
        );

        // Ýleri - geri hareket
        // Modelimizin burun yönü Unity'nin "back" yönüne baktýðý için
        // Vector3.back kullanýyoruz.
        transform.Translate(
            Vector3.back * ileriGeri * ileriGeriHizi * Time.deltaTime,
            Space.Self
        );
    }
}
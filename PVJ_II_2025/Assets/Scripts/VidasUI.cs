using UnityEngine;
using TMPro;

public class VidasUI : MonoBehaviour
{
    [Header("Referencias")]
    [SerializeField] private TextMeshProUGUI textoVidas;  

    private float cantidadVidas;

    private void Awake()
    {
  
        if (textoVidas == null)
            textoVidas = GetComponent<TextMeshProUGUI>();

        if (textoVidas == null)
            Debug.LogWarning($"{name}: No encontré TextMeshProUGUI. Asignalo en el Inspector.");
    }

    public void MostrarVidas(float vidas)
    {
        cantidadVidas = vidas;

        if (textoVidas != null)
        {
            // Formatos posibles: "0" (sin decimales), "0.0" (1 decimal), "N0" (con separador de miles)
            textoVidas.text = $"{Mathf.Max(0f, cantidadVidas):0}";
            // ejemplo con palabra: textoVidas.text = $"{Mathf.Max(0f, cantidadVidas):0} vidas";
        }
    }
}

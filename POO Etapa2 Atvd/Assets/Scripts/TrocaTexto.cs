using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TrocaTexto : MonoBehaviour
{
    public TextMeshProUGUI _texto;
    public TMP_InputField _inputField; 

    public void Trocar()
    {
        _texto.text = _inputField.text;
    }

}

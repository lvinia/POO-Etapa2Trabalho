using UnityEngine;
using UnityEngine.UI;


public class BarraDeVida : MonoBehaviour
{
    
    public Jogador jogador;
    [SerializeField]
    private int vidasRestantes = 0;
    [SerializeField]
    private int energiaRestante = 0;
    
    public Slider slider_vidasRestantes;
    
    public Slider slider_EnergiaRestante;    
    void Start()
    {
        
        // buscar jogador na cena:
        if (jogador == null)
        {
            //jogador = GameObject.Find("Jogador").GetComponent<Jogador>();
            jogador = GameObject.FindWithTag("Player").GetComponent<Jogador>();
        }

        if (jogador != null)
        {
            slider_vidasRestantes.minValue = 0;
            slider_vidasRestantes.maxValue = jogador.getVidas();

            slider_EnergiaRestante.minValue = 0;
            slider_EnergiaRestante.maxValue = jogador.getEnergia();
        }
        // vidasRestantes = jogador.getVidas();
        // energiaRestante = jogador.getEnergia();
    }

    
    void Update()
    {
        vidasRestantes = jogador.getVidas();
        slider_vidasRestantes.value = vidasRestantes;
        
        energiaRestante = jogador.getEnergia();
        slider_EnergiaRestante.value = energiaRestante;
    }
}

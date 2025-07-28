using UnityEngine;
using UnityEngine.UI;


public class BarraDeVida : MonoBehaviour
{
    
    public Personagem personagem;
    [SerializeField]
    private int vidasRestantes = 0;
    [SerializeField]
    private int energiaRestante = 0;
    
    public Slider slider_vidasRestantes;
    
    public Slider slider_EnergiaRestante;    
    void Start()
    {
        
        // buscar jogador na cena:
        if (personagem == null)
        {
            //jogador = GameObject.Find("Jogador").GetComponent<Jogador>();
            personagem = GameObject.FindWithTag("Player").GetComponent<Jogador>();
        }

        if (personagem != null)
        {
            slider_vidasRestantes.minValue = 0;
            slider_vidasRestantes.maxValue = personagem.getVidas();

            slider_EnergiaRestante.minValue = 0;
            slider_EnergiaRestante.maxValue = personagem.getEnergia();
        }
        // vidasRestantes = jogador.getVidas();
        // energiaRestante = jogador.getEnergia();
    }

    
    void Update()
    {
        if (slider_vidasRestantes != null)
        {
            vidasRestantes = personagem.getVidas();
            slider_vidasRestantes.value = vidasRestantes;
        }

        if (slider_EnergiaRestante != null)
        {
            energiaRestante = personagem.getEnergia();
            slider_EnergiaRestante.value = energiaRestante;
        }
        
        
        
    }
}

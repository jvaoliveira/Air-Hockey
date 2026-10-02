using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] int pontosPlayer;
    [SerializeField] int pontosInimigo;
    [SerializeField] Rigidbody disco;
    [SerializeField] Vector3 centro;
    [SerializeField] bool golMarcado = false;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        centro = disco.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GolMarcado(bool foiGolDoInimigo)
    {

        if (foiGolDoInimigo)
        {
            pontosInimigo++;
        }
        else
        {
            pontosPlayer++;
        }

        Debug.Log("Placar - Jogador: " + pontosPlayer + " | Inimigo: " + pontosInimigo);

        disco.position = centro;
        disco.linearVelocity = Vector3.zero; 
        disco.angularVelocity = Vector3.zero; 
    }
}

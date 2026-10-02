using UnityEngine;


public class enemyAI : MonoBehaviour
{

    
    [SerializeField] Transform disco;
    [SerializeField] Rigidbody inimigo;
    [SerializeField] float velocidadeInimigo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {

        Vector3 posicaoAlvo;

        if (disco.position.x <= -0.025f) 
        {
        
            if (disco.position.x < inimigo.position.x) 
            {
                
                posicaoAlvo = new Vector3(-0.9f, inimigo.position.y, 0f);
            }

            else 
            {
                
                posicaoAlvo = disco.position;
            }
        }
        else 
        {
            posicaoAlvo = new Vector3(-0.7f, inimigo.position.y, disco.position.z); 
        }

        Vector3 proximoPasso = Vector3.MoveTowards(inimigo.position, posicaoAlvo, velocidadeInimigo * Time.fixedDeltaTime);

        proximoPasso.x = Mathf.Clamp(proximoPasso.x, -1f, 0f);
        proximoPasso.z = Mathf.Clamp(proximoPasso.z, -0.5f, 0.5f);

        
        inimigo.MovePosition(proximoPasso);
    }
}

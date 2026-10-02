using UnityEngine;



public class NewMonoBehaviourScript : MonoBehaviour
{

    [SerializeField] Rigidbody rebatedor;
    [SerializeField] Vector3 pontoDeDestino;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        rebatedor = GetComponent<Rigidbody>();



    }

    // Update is called once per frame
    void Update()
    {
        
        Ray raio = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane ground = new Plane(Vector3.up, transform.position);

        if (ground.Raycast(raio, out float distancia)) 
        {
            pontoDeDestino = raio.GetPoint(distancia);
        }
    }


    void FixedUpdate()
    {
        pontoDeDestino.x = Mathf.Clamp(pontoDeDestino.x, 0f, 1.1f);

        pontoDeDestino.z = Mathf.Clamp(pontoDeDestino.z, -0.5f, 0.5f);

        rebatedor.MovePosition(pontoDeDestino);
    }
}

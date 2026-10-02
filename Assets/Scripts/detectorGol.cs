using UnityEngine;

public class detectorGol : MonoBehaviour
{

    [SerializeField] bool golDoInimigo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider outroObjeto)
{
    if (outroObjeto.CompareTag("Disco"))
        {
            GameManager golScript = FindAnyObjectByType<GameManager>();

            golScript.GolMarcado(golDoInimigo);
        }
}
}

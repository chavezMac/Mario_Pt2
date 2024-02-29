using UnityEngine;

public class BlockBehavior : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        print(Camera.main.transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {  
        if(Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit)) {
                if(hit.collider.gameObject == gameObject && gameObject.tag == "Brick") {
                    Destroy(gameObject);
                }
                if(hit.collider.gameObject == gameObject && gameObject.tag == "question") {
                    GameObject gameManager = GameObject.Find("GameManager");
                    GameManager gm = gameManager.GetComponent<GameManager>();
                    gm.score += 1;
                    gm.timerText.text = $"MARIO                      WORLD               Time: \n000000           x{gm.score}         1-1                     {400 - (int)Time.realtimeSinceStartup}";
                }
            }
        }
    }
}

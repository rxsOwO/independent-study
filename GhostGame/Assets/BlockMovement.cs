using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{
    public float time = 0f;
    public Grid gridLayout;
    Vector3Int cellPosition;
    Vector3 lerpPosition;
    bool lerpGo = false;
    Vector3 startPos;
    float startTime;
    float journeyLength;
    float speed = 10f;
    public string typename;
    public Reset reset;

    public AudioSource slide;
    // Start is called before the first frame update
    void Start()
    {
        reset = FindObjectsOfType<Reset>()[0];
        cellPosition = gridLayout.WorldToCell(transform.position);
        Debug.Log(cellPosition);
        transform.position = gridLayout.GetCellCenterWorld(cellPosition);
        Debug.Log(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if(lerpGo) {
            journeyLength = Vector3.Distance(startPos, lerpPosition);
            float distCovered = (Time.time - startTime) * speed;
            float fractionOfJourney = distCovered / journeyLength;
            transform.position = Vector3.Lerp(startPos, lerpPosition, fractionOfJourney);

            if(fractionOfJourney == 1f) {
                lerpGo = false;
            }
        }
    }
    void OnCollisionEnter2D (Collision2D other) {
        time = 0f;
    }
    public bool Ray(Vector2 dir) {
        RaycastHit2D hit;
        return hit = Physics2D.Raycast(transform.position, dir, 2f);
        
    }
    void OnCollisionStay2D(Collision2D other) {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) {
            time += Time.deltaTime;
        }
        else {
            time = 0f;
        }
        
        
        if(time>= 0.5f && other.gameObject.name == typename) {
            bool can = true;
            if(other.transform.position.x > transform.position.x+0.5 && can) { 
                time=0f;               
                can=false;
                Debug.DrawRay(new Vector2(transform.position.x-0.5f, transform.position.y), Vector2.left, Color.red);
                RaycastHit2D hit = Physics2D.Raycast(new Vector2(transform.position.x-0.5f, transform.position.y), Vector2.left, 0.5f);
                Debug.Log(hit.transform);
                if(!hit || hit.transform.gameObject.name == "Tilemap_" +typename + "Door") {
                cellPosition = cellPosition+ Vector3Int.left;
                //transform.position = gridLayout.GetCellCenterWorld(cellPosition);
                reset.moves -= 1;
                reset.text.text = reset.moves.ToString();
                slide.Play();
                lerpGo = true;
                startPos = transform.position;
                lerpPosition = gridLayout.GetCellCenterWorld(cellPosition);
                startTime = Time.time;
                }


            }
            if(other.transform.position.x < transform.position.x -0.5&& can) {
                time=0f;
                Debug.DrawRay(new Vector2(transform.position.x+0.5f, transform.position.y), Vector2.right, Color.red);
                RaycastHit2D hit = Physics2D.Raycast(new Vector2(transform.position.x+0.5f, transform.position.y), Vector2.right, 0.5f);
                Debug.Log(hit.transform);
                can=false;
                if(!hit || hit.transform.gameObject.name == "Tilemap_" +typename + "Door") {
                cellPosition = cellPosition+ Vector3Int.right;
                //transform.position = gridLayout.GetCellCenterWorld(cellPosition);
                reset.moves -= 1;
                reset.text.text = reset.moves.ToString();
                slide.Play();
                lerpGo = true;
                startPos = transform.position;
                lerpPosition = gridLayout.GetCellCenterWorld(cellPosition);
                startTime = Time.time;
                }
            }
            if(other.transform.position.y < transform.position.y-0.5 && can) {
                time=0f;
                Debug.DrawRay(new Vector2(transform.position.x, transform.position.y+0.5f), Vector2.up, Color.red);
                RaycastHit2D hit = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y+0.5f), Vector2.up, 0.5f);
                Debug.Log(hit.transform);
                can=false;
                if(!hit || hit.transform.gameObject.name == "Tilemap_" +typename + "Door") {
                cellPosition = cellPosition+ Vector3Int.up;
                //transform.position = gridLayout.GetCellCenterWorld(cellPosition);
                reset.moves -= 1;
                reset.text.text = reset.moves.ToString();
                slide.Play();
                lerpGo = true;
                startPos = transform.position;
                lerpPosition = gridLayout.GetCellCenterWorld(cellPosition);
                startTime = Time.time;
                }
            }
            if(other.transform.position.y > transform.position.y+0.5 && can) {
                time=0f;
                Debug.DrawRay(new Vector2(transform.position.x, transform.position.y-0.5f), Vector2.down, Color.red);
                RaycastHit2D hit = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y-0.5f), Vector2.down, 0.5f);
                Debug.Log(hit.transform);
                can=false;
                if(!hit || hit.transform.gameObject.name == "Tilemap_" +typename + "Door") {
                cellPosition = cellPosition+ Vector3Int.down;
                //transform.position = gridLayout.GetCellCenterWorld(cellPosition);
                reset.moves -= 1;
                reset.text.text = reset.moves.ToString();
                slide.Play();
                lerpGo = true;
                startPos = transform.position;
                lerpPosition = gridLayout.GetCellCenterWorld(cellPosition);
                startTime = Time.time;
                }
            }
        
        }
    }
}

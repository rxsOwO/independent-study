using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{
    public float time = 0f;
    public GridLayout gridLayout;
    Vector3Int cellPosition;
    // Start is called before the first frame update
    void Start()
    {
        
        cellPosition = gridLayout.WorldToCell(transform.position);
        transform.position = gridLayout.CellToWorld(cellPosition);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D (Collision2D other) {
        time = 0f;
    }
    void OnCollisionStay2D(Collision2D other) {
        time += Time.deltaTime;

        if(time>= 0.5f) {
            transform.position = gridLayout.CellToWorld(new Vector3Int(cellPosition.x +1, cellPosition.y, cellPosition.z));
            cellPosition = gridLayout.WorldToCell(transform.position);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour {
    [SerializeField] private float speed;
    CharacterController cc;
    private void Awake()
    {
        cc = GetComponent<CharacterController>();
    }
    private void Update()
    {
        PMov();
    }

    private void PMov()
    {
        float HorMov = Input.GetAxis("Horizontal") * speed;
        Vector3 vec = new Vector3(HorMov * Time.deltaTime, 0 , speed * Time.deltaTime);
        cc.Move(vec);
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeGrunts : Enemy
{
    
    void Start()
    {
        rb.gravityScale = 12f;
        
    }
    protected override void Awake()
    {
        base.Awake();
    }
    
    protected override void Update()
    {
        base.Update();
        if(!isRecoiling)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(PLayerController.Instance.transform.position.x, transform.position.y), speed * Time.deltaTime);
        }
    }

    public override void Enemyhit(float _damageDone, Vector2 _hitDirection, float _hitForce)
    {
        base.Enemyhit(_damageDone, _hitDirection, _hitForce);
    }
}

using UnityEngine;

public class FlyCharacter : MonoBehaviour
{
    public float health;
    
    public virtual void Flying()
    {

    }

    public virtual void Attack()
    {

    }

    public virtual void TakeDamage(float damageForce)
    {
        health -= damageForce;
    }

    public virtual void Die()
    {

    }

}

public class Bee : FlyCharacter
{
    public float speed;
    public override void Flying()
    {

    }

    public override void Attack()
    {

    }

    public override void TakeDamage(float damageForce)
    {
       
    }

    public override void Die()
    {
        
    }
}

public class Bat : FlyCharacter 
{
    public float speed;
    public override void Flying()
    {

    }

    public override void Attack()
    {

    }

    public override void TakeDamage(float damageForce)
    {

    }

    public override void Die()
    {

    }
}

public class Bug : FlyCharacter
{
    public float speed;
    public override void Flying()
    {

    }

    public override void Attack()
    {

    }

    public override void TakeDamage(float damageForce)
    {

    }

    public override void Die()
    {

    }
}

public class Fly : FlyCharacter 
{
    public float speed;
    public override void Flying()
    {

    }

    public override void Attack()
    {

    }

    public override void TakeDamage(float damageForce)
    {

    }

    public override void Die()
    {

    }
}


using UnityEditor;
using UnityEngine;

public class WalkCharacter : MonoBehaviour
{
    public float health = 100;
    
    public virtual void Start()
    {

    }
    public virtual void Walk()
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
  

public class Spider : WalkCharacter
{
    public float speed;
    public override void Walk()
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

public class Snail : WalkCharacter
{
    public float speed;
    public override void Walk()
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

public class Worm : WalkCharacter
{
    public float speed;
    public override void Walk()
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

public class Slime : WalkCharacter 
{
    public float speed;
    public override void Walk()
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

public class Frog : WalkCharacter
{
    public float speed;
    public override void Walk()
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

public class Mouse : WalkCharacter
{
    public float speed;
    public override void Walk()
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

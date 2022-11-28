using System.Numerics;
using System.Runtime.CompilerServices;
using ShibaEngineCore;


public class Test2 : Component
{
    public float speed = 0.0f;
    public override void Start()
    {
        base.Start();
    }
    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.KEY_T))
        {
            Transform.Position += Vector3.UnitY * speed * Time.deltaTime;
        }
    }
}
public class Test : Component
{
    public uint otherEntity;
    public float speed;
    public Physics physics;
    public override void Start()
    {
        physics = EngineCalls.GetCoreComponent<Physics>(entity);
    }
    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.KEY_SPACE))
        {
            physics.UseGravity = false;
        }
        if (Input.GetKeyDown(KeyCode.KEY_F))
        {
            physics.UseGravity = true;
        }
        if (Input.GetKeyDown(KeyCode.KEY_P))
        {
            physics.GravityDirection = Vector3.UnitY;
        }
    }
}
using UnityEngine;

public class EnemyManger : MonoBehaviour
{

    [Header("怪物一號")]
    public Enemy enemy1;
    [Header("怪物二號")]
    public Enemy enemy2;

    
    private void Start()
    {
        print("怪物一號的魔力：" + enemy1._mp);
        print("怪物二號的裝備名稱：" + enemy2._item);
        

        enemy1._hp      = 100;
        enemy2._hp      = 300;
        enemy1._def     = 50;
        enemy1._weapon  = "木棍";
        enemy2._weapon  = "短刀";
        enemy1._key     = true;
        enemy2._money   = true;
    }


}

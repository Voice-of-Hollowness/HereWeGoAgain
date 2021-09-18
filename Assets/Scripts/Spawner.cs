using System.Collections;
using Assets.Scripts;
using UnityEngine;

public class Spawner : MonoBehaviour
{
  /*  public bool devMode;

    public Waves[] waves;
        public Enemy enemy;
        int Alives;

       Waves curWave;
       int curWaveNum;

    int enemiesRemain2Spwn;
    private float nexSpwnTime;

    private LivingEntetity playerEntetity;
    private Transform playerT;

    private float timeBtwnCampCheks = 2;
    private float campGetOutDist = 1.5f;
    private float nextCampCheckTime;
    private Vector3 campPositionOld;

    private bool isDisablyad;

    public event System.Action<int> OnNewWave;



    void Start()
     {
         playerEntetity = FindObjectOfType<Player>();
         playerT = playerEntetity.transform;


         nextCampCheckTime = timeBtwnCampCheks + Time.time;
         campPositionOld = playerT.position;

         playerEntetity.OnDeath += OnPlayerDeath;


         Debug.Log("Spawner is on");
         NexWave();
 }

    private void Update() {
        if(!isDisablyad){
            if (Time.time>nextCampCheckTime){
                nextCampCheckTime = timeBtwnCampCheks + Time.time;
            
                isCamping = (Vector3.Distance(playerT.position,campPositionOld)<campGetOutDist);
                campPositionOld = playerT.position;
            }




            if ((enemiesRemain2Spwn>0 || curWave.infinite )&& Time.time>nexSpwnTime)
            {
                enemiesRemain2Spwn--;
                nexSpwnTime = Time.time + curWave.TBeetwnWaves;
                StartCoroutine(spawnAnEnemy());
            }

        }

        if (devMode)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                StopCoroutine(spawnAnEnemy());
                foreach (Enemy enemy in FindObjectsOfType<Enemy>() )
                {
                    GameObject.Destroy(enemy);
                }
                NexWave();
            }
        }
    }

    IEnumerator spawnAnEnemy()
    {
        float spwnDelay = 1;



        Transform randomSpawnpoint = map.GetRandomOpenTile();

        

        float spwnTimer = 0;

        while (spwnTimer < spwnDelay)
        {
        
            spwnTimer += Time.deltaTime;
            yield return null;
        }

        Enemy spawnedEnemy = Instantiate(
            original: enemy,
            position: randomSpawnpoint.position + Vector3.up,
            rotation: Quaternion.identity) as Enemy;

        spawnedEnemy.OnDeath += OnEnemyDeath;
    }

    void OnPlayerDeath()
    {
        isDisablyad=true;
    }

    void OnEnemyDeath()
    {
        Alives--;
        if (Alives == 0)
        {
            NexWave();
        }
    }

   
    void NexWave()
        {
   

            curWaveNum++;
            if (curWaveNum-1<waves.Length)
            {
            

                curWave = waves[curWaveNum - 1];

                enemiesRemain2Spwn = curWave.enemyCount;
                Alives = enemiesRemain2Spwn;

                if (OnNewWave != null)
                {
                   OnNewWave(curWaveNum);
                }
            }

          
        }


        [System.Serializable]
    public class Waves
    {
        public int enemyCount;
        public float TBeetwnWaves;
        public bool infinite;

    }*/
}

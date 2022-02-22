using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkLoader : MonoBehaviour
{
    public Chunk[] ChunkPrefabs;
    public Chunk[] ChunkPrefabs1;
    public PlayerScript PlayerScript;
    
    

    Dictionary<int, Chunk> LoadedChunks = new Dictionary<int, Chunk>();
    public int chunkLoadingRange = 1;

    float timer = 0;

    // Update is called once per frame
    void Update()
    {    
        timer += Time.deltaTime;

        if(timer > 1)
        {
            timer = 0;
            CheckForNewChunks();
        }
    }

    void CheckForNewChunks()
    {
        Vector3 playerPos = PlayerScript.transform.position;
        int playerPosX = GetChunkPos(playerPos.x);

        int chunkPosX;
        for (int x = -chunkLoadingRange; x < chunkLoadingRange; x++)
        {
            chunkPosX = playerPosX + (x * 10);

            if(!LoadedChunks.ContainsKey(chunkPosX))
            {
                GenerateChunk(chunkPosX);
            }
        }
    }

    int GetChunkPos(float x)
    {
        //x = 11.5
        x /= 10;//x = 1.15;
        x = Mathf.Floor(x);// x = 1
        x *= 10; //x = 10

        return (int)x;
    }

    void GenerateChunk(int posX)
    {
        
        GameObject chunkGameObject = Instantiate(GetRandomChunk());
        Chunk chunkScript = chunkGameObject.GetComponent<Chunk>();

        chunkGameObject.transform.position = Vector3.zero + new Vector3(posX, 0, 0);

        LoadedChunks.Add(posX, chunkScript);
    }

    //Todo random generator
    GameObject GetRandomChunk()
    {
        int zufall;
        

        
        
        
        zufall = Random.Range(0, ChunkPrefabs.Length -1);
        
        return ChunkPrefabs[zufall].gameObject;
    }
}

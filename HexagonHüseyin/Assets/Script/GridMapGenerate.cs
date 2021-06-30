using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class GridMapGenerate : MonoBehaviour
{

    public GameObject[] hexPrefab;
   [SerializeField] int mapWidth = 8;
   [SerializeField] int mapHeight = 9;
    float tileXOffset = 0.80f;
    float tileZOffset = 0.78f;
    public GameObject[,] prefabArray;
    void Start()
    {

        CreateHexTileMap();
        prefabArray = new GameObject[500, 500];


    }

    void Update()
    {

      




    }
    void CreateHexTileMap(){
        
        //map Width Generator
        for (int x=0; x < mapWidth; x++)
        {
            
            //map Height Generator
            for (int y = 0; y < mapHeight; y++) {



                GameObject Haxagon = Instantiate(hexPrefab[Random.Range(0,hexPrefab.Length)]) ;
                //Haxagona hexagon ıd kodunun çağırdı
                Haxagon.AddComponent<HexagonID>();
                //Hexagon İD scriptinden değişken çekip burdaki değerlere atadı (X VE Y DEĞİŞKEN)
                Haxagon.GetComponent<HexagonID>().x = x;
                Haxagon.GetComponent<HexagonID>().y = y;
              

                
                //grid posistion
                Haxagon.transform.position = new Vector3(x * tileXOffset, y * tileZOffset,0) ;
                if (y % 2 != 0)
                {

                    Haxagon.transform.position = new Vector3(x * tileXOffset + tileXOffset / 2, y * tileZOffset, 0);
                }
                   

             



            }


        }


    }

  
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int life = 100;
    public float velocidade = 1500.2f;
    public bool isActive = true;
    public string nomePlayer = "example";
    public int counter = 0;


    public GameObject chao; // lista de game objects
    public Transform inimigo; // dados de x, y e z de um game object

    public int diaSemana;


    public List<float> numeros = new List<float>();

    public int[] arrayInt = { 1, 2, 3, 4, 5 };

    void Attack()
    {

    }



     // Start is called before the first frame update
    void Start()
    {

        numeros.Add(10);
        numeros.Add(20);
        numeros.Add(30);
        numeros.Add(40);
        numeros.Add(50);
        numeros.Add(2);
        numeros.Add(2);
        numeros.Add(7);
        numeros.Add(9);

        numeros.Remove(2); // ele não remove o index 2 e sim o primeiro numero 2

        numeros.Clear();

        if ( 1 ==  1)
        {
            Debug.Log("NICEEEEE 1 times"); 
        }

        switch(diaSemana)
        {
            case 1:
                Debug.Log("Segunda");
                break;

            case 2:
                Debug.Log("Terça");
                break;

            case 3:
                Debug.Log("Quarta");
                break;
            default:
                Debug.Log("Não mapeado");
                break;

        }


        for(int i = 0; i< 10; i+=1)
        {
            Debug.Log(i);
        }

        foreach(int valor in arrayInt)
        {
            Debug.Log(valor);
        }
        
    }

    /// <summary>
    /// sdsds
    /// </summary>
    // Update is called once per frame
void Update()
    {
        this.counter += 1;
        // Debug.Log(this.counter);


        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("DOWN SPACE");
        }
    }
   
      
   


  //void Attack()
  //{
//
  //}

  //void Moviment ()
   //

   //

  //void Hit()
   //

  //}
}

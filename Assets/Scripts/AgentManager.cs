using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    GameObject[] agents;
    
    void Start()
    {
        agents = GameObject.FindGameObjectsWithTag("ai");//Procurando objeto com a tag "ai"
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//Quando clicar com o mouse, irá pegar a informação do Raycast e irá até o destino.
        {
            RaycastHit hit;//guarda informações do objeto
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                foreach (GameObject a in agents)
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point);
            }
        }
    }
}

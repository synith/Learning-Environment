using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.AI;

public class CommandControlledBot : MonoBehaviour // this is an example of the Command Pattern
{
    private NavMeshAgent agent;

    private Queue<Command> commands = new Queue<Command>();
    private Command currentCommand;

    private void Start() => agent = GetComponent<NavMeshAgent>();

    private void Update()
    {
        ListenForCommands();
        ProcessCommands();
    }

    private void ProcessCommands()
    {
        if (currentCommand != null && currentCommand.IsFinished == false)
            return;

        if (commands.Any() == false)
            return;

        currentCommand = commands.Dequeue();
        currentCommand.Execute();
    }
    private void ListenForCommands()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                MoveCommand moveCommand = new MoveCommand(hitInfo.point, agent);
                commands.Enqueue(moveCommand);
            }
        }
    }
}

internal class MoveCommand : Command
{
    private readonly Vector3 destination;
    private readonly NavMeshAgent agent;

    public MoveCommand(Vector3 destination, NavMeshAgent agent)
    {
        this.destination = destination;
        this.agent = agent;
    }
    public override void Execute() => agent.SetDestination(destination);

    public override bool IsFinished => agent.remainingDistance <= 0.1f;
}

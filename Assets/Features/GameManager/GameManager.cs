using UnityEngine;

public class GameManager : MonoBehaviour
{   
    public static GameManager instance;

    private StateMachine stateMachine;
    [SerializeField] private AudioSource backgroundAudioSource = null;


    private void Awake()
    {
        if (instance != null && instance != this)
            Destroy(gameObject);
        else
            instance = this;
    }

    private void Start()
    {
        this.stateMachine = new StateMachine();
        
        this.stateMachine.ChangeState(new TutorialRoomState(this.backgroundAudioSource));
        this.stateMachine.ExecuteStateUpdate();
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}

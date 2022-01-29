using UnityEngine;

public class TutorialRoomState : IState
{
    private AudioSource backgroundMusicAudioSource = null;

    public TutorialRoomState(AudioSource audioSource)
    {
        this.backgroundMusicAudioSource = audioSource;
    }

    public void EnterState()
    {
        Debug.Log(">>>>>ENTER TUTORIAL ROOM STATE<<<<<");
        Debug.Log(this.backgroundMusicAudioSource.clip.name);
    }

    public void ExecuteState()
    {
        Debug.Log(">>>>>EXECUTE TUTORIAL ROOM STATE<<<<<");
        this.backgroundMusicAudioSource.Play();
    }

    public void ExitState()
    {
        Debug.Log(">>>>>EXIT TUTORIAL ROOM STATE<<<<<");
    }
}

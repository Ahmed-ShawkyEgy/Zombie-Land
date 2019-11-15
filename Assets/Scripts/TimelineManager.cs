using UnityEngine;
using UnityEngine.Playables;


public class TimelineManager : Singleton<TimelineManager>
{
    public PlayableDirector introDir , gunFightDir1 , gunHelpDir, gunIgnoreDir, axeFightDir1, axeFightHelpDir ;

    void OnEnable()
    {
        introDir.stopped += OnPlayableDirectorStopped;
        gunFightDir1.stopped += OnPlayableDirectorStopped;
        axeFightDir1.stopped += OnPlayableDirectorStopped;
        axeFightHelpDir.stopped += OnPlayableDirectorStopped;
    }

    void OnPlayableDirectorStopped(PlayableDirector aDirector)
    {
        if (introDir == aDirector)
        {
            GameManager.Instance.showWeponChoice();
        }
        else if (gunFightDir1 == aDirector)
        {
            GameManager.Instance.showHelpChoice();
        }
        else if (axeFightDir1 == aDirector)
        {
            GameManager.Instance.showHelpChoiceWithAxe();
        }
    }

    public void PlayAxeFight()
    {
        axeFightDir1.Play();
    }

    public void PlayGunFight()
    {
        gunFightDir1.Play();
    }

    public void PlayGunHelpFight()
    {
        gunHelpDir.Play();
    }

    public void PlayGunIgnoreFight()
    {
        gunIgnoreDir.Play(); 
    }

    public void PlayAxeFightHelp()
    {
        axeFightHelpDir.Play();
    }

    void OnDisable()
    {
        introDir.stopped -= OnPlayableDirectorStopped;
        gunFightDir1.stopped -= OnPlayableDirectorStopped;
        axeFightDir1.stopped -= OnPlayableDirectorStopped;
        axeFightHelpDir.stopped -= OnPlayableDirectorStopped;
    }
}

using UnityEngine;
using UnityEngine.Playables;


public class TimelineManager : Singleton<TimelineManager>
{
    public PlayableDirector introDir , gunFightDir1 , gunHelpDir, gunIgnoreDir, axeFightDir1 ;

    void OnEnable()
    {
        introDir.stopped += OnPlayableDirectorStopped;
        gunFightDir1.stopped += OnPlayableDirectorStopped;
    }

    void OnPlayableDirectorStopped(PlayableDirector aDirector)
    {
        if (introDir == aDirector)
        {
            GameManager.Instance.showWeponChoice();
        }
        else if(gunFightDir1 == aDirector)
        {
            GameManager.Instance.showHelpChoice();
        }
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

    void OnDisable()
    {
        introDir.stopped -= OnPlayableDirectorStopped;
        gunFightDir1.stopped -= OnPlayableDirectorStopped;
    }
}

using UnityEngine;
using UnityEngine.Playables;


public class TimelineManager : Singleton<TimelineManager>
{
    public PlayableDirector introDir , gunFightDir1 , axeFightDir1;

    void OnEnable()
    {
        introDir.stopped += OnPlayableDirectorStopped;
    }

    void OnPlayableDirectorStopped(PlayableDirector aDirector)
    {
        if (introDir == aDirector)
        {
            GameManager.Instance.showWeponChoice();
        }
    }

    void OnDisable()
    {
        introDir.stopped -= OnPlayableDirectorStopped;
    }
}

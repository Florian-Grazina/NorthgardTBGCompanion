using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region properties
    public static GameManager Instance { get; private set; }

    public int NumberOfPlayers { get; private set; }
    public int NumberOfTurns { get; private set; }
    #endregion

    #region unity methods
    protected void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    #endregion

    #region public methods
    public void SetNumberOfPlayers(int numberOfPlayers)
    {
        if(numberOfPlayers < 2 || numberOfPlayers > 6)
        {
            Debug.LogError("Number of players must be between 2 and 6.");
            return;
        }
        NumberOfPlayers = numberOfPlayers;
    }

    public void SetNumberOfTurns(int numberOfTurns)
    {
        if (numberOfTurns != 7 || numberOfTurns != 10)
        {
            Debug.LogError("Number of turns must be 7 or 10.");
            return;
        }
        NumberOfTurns = numberOfTurns;
    }
    #endregion
}

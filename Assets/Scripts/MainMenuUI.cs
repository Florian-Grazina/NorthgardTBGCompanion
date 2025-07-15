using TMPro;
using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown playerDropdown;
    [SerializeField] private TMP_Dropdown turnsDropdown;

    private GameManager GameManager => GameManager.Instance;

    public void StartGame()
    {
        GameManager.SetNumberOfPlayers(GetValueFromDropdown(playerDropdown));
        GameManager.SetNumberOfTurns(GetValueFromDropdown(turnsDropdown));
        GameManager.PrintData();
    }

    private int GetValueFromDropdown(TMP_Dropdown dropdown)
    {
        if(int.TryParse(dropdown.options[dropdown.value].text, out int parseValue))
            return parseValue;
        return 0;
    }
}

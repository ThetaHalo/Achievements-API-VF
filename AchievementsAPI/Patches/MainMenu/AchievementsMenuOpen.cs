using UnityEngine;

namespace AchievementsAPI.Patches.MainMenu;

public class AchievementsMenuOpen
{
    public static void OpenMenu(MainMenuManager mainMenuManager)
    {
        var menu = UnityEngine.Object.Instantiate(Assets.achievementPrefab).GetComponent<AchievementsMenu>();
        menu.mainMenuManager = mainMenuManager;
        menu.gameObject.SetActive(true);
    }
}
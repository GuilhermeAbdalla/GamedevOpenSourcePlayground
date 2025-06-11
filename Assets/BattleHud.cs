using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BattleHud : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI levelText;
    public Image hpSlider;

    public void SetHUD(Unit unit)
    {
        nameText.text = unit.unitName;
        levelText.text = "Lvl " + unit.unitLevel;
        hpSlider.fillAmount = unit.currentHP /unit.maxHP;
    }

    public void SetHP(int maxHp, int currentHp)
    {
        hpSlider.fillAmount = currentHp / maxHp;
    }
}

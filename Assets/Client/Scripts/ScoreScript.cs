using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] private int _targetAmount;
    [SerializeField] private GameObject _endGamePanel;
    [SerializeField] private Text _endText;
    [SerializeField] private BulletCountScript BulletCountScript;

    public static bool _IsTargetDestroyed = false;


    private void Update()
    {
        if (_IsTargetDestroyed)
        {
            _targetAmount -= 1;
            _IsTargetDestroyed = false;
        }
        if (_targetAmount <= 0 || BulletCountScript._bulletCount <= 0)
        {
            _endGamePanel.SetActive(true);
            if (_targetAmount <= 0)
                _endText.text = "You Win!!!";
            else if (BulletCountScript._bulletCount <= 0)
                _endText.text = "You Lose!!!";
 
            Time.timeScale = 0;
        }
    }
}

public interface IScoreManager
{
    void AddScore(ScoreItem scoreItem);
    int GetScore();
    void RegisterScoreItem(ScoreItem scoreItem);
}
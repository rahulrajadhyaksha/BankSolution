namespace BankLibrary
{
    public interface ICreditScorer
    {
        int Score { get; }

        void CalculateScore(string applicantName, string applicantAddress);


        //add
        ScoreResult ScoreResult { get; }

        //add 2

        int Count { get; set; }
    }
}
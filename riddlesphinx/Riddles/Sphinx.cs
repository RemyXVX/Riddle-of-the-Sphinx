using System;

namespace Riddles.Tales {

  public class Saying
  {
    private string _riddleToAsk;
    private string _answerToRiddle;

    public Saying(string riddleNow, string answerToRiddle)
    {
      _riddleNow = riddleToAsk;
      _answerToRiddle = answerToRiddle;
    }

    public string GetRiddleToAsk()
    {
      return _riddleToAsk;
    }

    public string GetAnswerToRiddle()
    {
      return _answerToRiddle;
    }
  }
}
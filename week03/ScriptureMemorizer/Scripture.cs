using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
    _reference = reference;

    _words = new List<Word>();

    string[] splitWords = text.Split(' ');

    foreach (string wordText in splitWords)
    {
        Word newWord = new Word(wordText);
        _words.Add(newWord);
    }
    }

    public void HideRandomWords(int numberToHide)
    {

     Random random = new Random();

    for (int i = 0; i < numberToHide; i++)
    {
        
        int randomIndex = random.Next(_words.Count);

        _words[randomIndex].Hide();
    }

    }

    public string GetDisplayText()
    {
      List<string> wordsText = new List<string>();

       foreach (Word word in _words)
       {
          wordsText.Add(word.GetDisplayText());
       }

     string scriptureText = string.Join(" ", wordsText);

     return $"{_reference.GetDisplayText()} {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
      foreach (Word word in _words)
       {
          if (!word.IsHidden())
          {
             return false;
          }
       }

      return true;
    }
}

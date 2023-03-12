class RandomScriptureVerse
{
    private Random randomGenerator = new Random();
    private string _scripture;
    private List<string> _scriptures = new List<string>() {
        "John 3:16 For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
        "Philippians 3:14 I press toward the mark for the prize of the high calling of God in Christ Jesus.",
        "Proverbs 3:13 Happy is the man that findeth wisdom, and the man that getteth understanding.",
        "James 3:13 Who is wise and understanding among you? Let them show it by their good life, by deeds done in the humility that comes from wisdom.",
        "2 Corinthians 5:17 Therefore, if anyone is in Christ, the new creation has come: The old has gone, the new is here!",
        "Proverbs 3:5-6 5 Trust in the Lord with all your heart and lean not on your own understanding; 6 in all your ways submit to him, and he will make your paths straight.",
        "Romans 7:2-3 2 For the woman which hath an husband is bound by the law to her husband so long as he liveth; but if the husband be dead, she is loosed from the law of her husband.;3 So then if, while her husband liveth, she be married to another man, she shall be called an adulteress: but if her husband be dead, she is free from that law; so that she is no adulteress, though she be married to another man.",
        "Luke 12:33-34 33 Sell that ye have, and give alms; provide yourselves bags which wax not old, a treasure in the heavens that faileth not, where no thief approacheth, neither moth corrupteth.;34 For where your treasure is, there will your heart be also.",
        "Colossians 3:9-10 9 Lie not one to another, seeing that ye have put off the old man with his deeds;10 And have put on the new man, which is renewed in knowledge after the image of him that created him:"
    };

    public RandomScriptureVerse()
    {
        int randScripture = randomGenerator.Next(0,_scriptures.Count());
        _scripture = _scriptures[randScripture];
        Console.WriteLine(_scripture);
    }
}
using System;

public class Scripture
{
    private string scriptCont;

    public Scripture()
    {
        scriptCont = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
    }

    public string GetScripture()
    {
        return scriptCont;
    }

    public void SetScripture(string newScripture)
    {
        scriptCont = newScripture;
    }

    
}
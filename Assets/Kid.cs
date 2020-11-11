using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kid : MonoBehaviour
{
    private void Start()
    {
        PrintMessage();

        DisobedientKid disobedientKid = new DisobedientKid();
        disobedientKid.PrintMessage();

        ArtisticKid artisticKid = new ArtisticKid();
        artisticKid.PrintMessage();

        FriendlyKid friendlyKid = new FriendlyKid();
        friendlyKid.PrintMessage();
    }

    public virtual void PrintMessage()
    {
        Debug.Log("Hello");
    }
}

public class DisobedientKid : Kid
{
    public override void PrintMessage()
    {
        Debug.Log("What");
    }
}

public class ArtisticKid : Kid
{
    public override void PrintMessage()
    {
        Debug.Log("I am painting");
    }
}

public class FriendlyKid : Kid
{
    public override void PrintMessage()
    {
        Debug.Log("Hi");
    }
}

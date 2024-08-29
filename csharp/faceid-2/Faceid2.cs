using System;
using System.Collections.Generic;

public record FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
    // TODO: implement equality and GetHashCode() methods
}

public record Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }

    public int OtherHashCode()
    {
        return base.GetHashCode();
    }
    // TODO: implement equality and GetHashCode() methods
}

public class Authenticator
{
    private HashSet<Identity> lista = new HashSet<Identity>();
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    {
        return faceA == faceB;
    }

    public bool IsAdmin(Identity identity)
    {
        return identity == new Identity("admin@exerc.ism", new FacialFeatures("green", 0.9m));
    }

    public bool Register(Identity identity)
    {
        return lista.Add(identity);
    }

    public bool IsRegistered(Identity identity)
    {
        return lista.Contains(identity);
    }

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        return identityA.OtherHashCode() == identityB.OtherHashCode();
    }
}

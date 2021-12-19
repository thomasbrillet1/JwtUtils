﻿namespace JwtUtils;

public partial class JwtUtils
{
    public static partial class Asymmetric
    {
        public static partial class Token
        {
        }
    }
    
    public static partial class Symmetric
    {
        public static partial class Token
        {
        }
    }
}

internal readonly ref struct JwtPartData
{
    public readonly ReadOnlyMemory<char> Payload;
    public readonly ReadOnlyMemory<char> Signature;

    public JwtPartData(ReadOnlyMemory<char> payload, ReadOnlyMemory<char> signature)
    {
        Payload = payload;
        Signature = signature;
    }
}
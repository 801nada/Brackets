﻿using Xunit;

namespace Brackets;
public class BracketsTests
{
    [Fact]
    public void Simple_pair_brackets()
    {
        var result = Iterations.HasClosingBrace3("{}");
        Assert.True(result);
    }

    [Fact]
    public void Reversed_pair_brackets()
    {
        var result = Iterations.HasClosingBrace3("}{");
        Assert.False(result);
    }


    [Fact]
    public void Reversed_pair_brackets_in_middle()
    {
        var result = Iterations.HasClosingBrace3("{ddsf}}{sdfs}{ds");
        Assert.False(result);
    }

    [Fact]
    public void Multiple_pair_brackets()
    {
        var result = Iterations.HasClosingBrace3("{dd{sds}}");
        Assert.True(result);
    }

    [Fact]
    public void Multiple_braces_close()
    {
        var result = Iterations.HasClosingBrace3("{dd}}");
        Assert.False(result);
    }

    [Fact]
    public void Multiple_braces_open()
    {
        var result = Iterations.HasClosingBrace3("{{{dd}}");
        Assert.False(result);
    }

    [Fact]
    public void Empty_string()
    {
        var result = Iterations.HasClosingBrace3("");
        Assert.True(result);
    }

    [Fact]
    public void Non_braces_only()
    {
        var result = Iterations.HasClosingBrace3("serfv4185");
        Assert.True(result);
    }
}

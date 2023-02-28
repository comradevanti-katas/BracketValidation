namespace BracketValidation;
using static BracketValidation;

public class BracketValidationTests
{

    [Fact]
    public void Empty_String_Is_Valid()
    {
        var isValid = IsValid("");
        Assert.True(isValid);
    }
    
}
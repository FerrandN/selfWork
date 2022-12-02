string palindrome = "RADTRYUYRTDAR";

Console.WriteLine(checkPalindrome(palindrome));

static bool checkPalindrome(string _s)
{
    if (_s.Length <= 1)
    {
        return true;
    }
    else
    {
        if (_s[0] != _s[_s.Length -1])
        {
            return false;
        }
        else 
            return checkPalindrome(_s.Substring(1, _s.Length-2));
    }
}
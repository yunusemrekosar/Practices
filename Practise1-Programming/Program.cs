using System.Collections.Concurrent;

#region Static and Dynamic Arrays

int[] _array = new int[5];

int[] _array2 = (int[])Array.CreateInstance(typeof(int), 5);

// Actually ı dont understand the difference between them. I can do same things both. If I don't understand after looking up dynamic and static things, I will ask it when see a person that could be know it. 
#endregion

#region Ref 

#region Ref Return
{
    string str = "abcdefg";
    {

        var str2 = getRef(ref str);
        str2 += str[0];

        //Console.WriteLine(str);
    }

    str = "abcdefg";

    {
        ref var str2 = ref getRef(ref str);
        str2 += str[0];

        //Console.WriteLine(str);
    }

    ref string getRef(ref string str)
    {
        str += "h";
        return ref str;
    }
}

#endregion

#region Ref Local
{
    string str = "abcdefg";

    ref var str2 = ref str;
    str2 += str[0];

    //Console.WriteLine(str);

}
#endregion

// I can understand when look at the code. So ı dont explain this. A hint, ref type and value type

// could be useful to getting rid of deep copies and help to keep clean memory.
#endregion



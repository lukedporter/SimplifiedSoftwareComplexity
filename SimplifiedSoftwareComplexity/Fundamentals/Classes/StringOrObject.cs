namespace SimplifiedSoftwareComplexity.Fundamentals
{
    public class StringOrObject
    {
        public string? Str = null;
        public object? Obj = null;
        public bool? isString = null;
        public StringOrObject(string str)
        {
            isString = true;
            Str = str;
        }
        public StringOrObject(object obj)
        {
            isString = false;
            Obj = obj;
        }
        public void HowToRetrieveStringOrObject()
        {
            // informational only, do not want to return dynamic types.
            if (isString != null) // this would mean the class is not properly implemented.
            {
                if (isString == true && Str != null)
                {
                    // handle as string.
                }
                else if (isString == false && Obj != null)
                {
                    // handle as object.
                }
                else
                {
                    // can return null here.
                }
            }
            else
            {
                // can return null here or throw an error for developers.
            }
        }
    }
}

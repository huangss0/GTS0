namespace HssUtility.Service.JSON
{
    public class JSON_helper
    {    
        public static bool IsNum(char c)
        {
            return c >= '0' && c <= '9';
        }

        public static bool IsLetter(char c)
        {
            if (c == ' ' || c == '\"' || c == ':' || c == '=') return false;
            if (c == ',' || c == ';') return false;
            if (c == 9) return false; //Tab character
            if (c == '{' || c == '}' || c == '[' || c == ']') return false;
            if (c == '\n' || c == '\r') return false;

            return true;
        }        
    }
}

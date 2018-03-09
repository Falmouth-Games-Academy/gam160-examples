using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StringHandling
{
    //Class to wrap up a String Builder, we could
    //create one of these to manage all dynamic text
    //in our game
    public class StringHandler
    {
        //Max of 1024 characters, this is used if we call
        //the default constructor
        const int MAX_DEFAUL_SIZE = 1024;
        //String Builder
        private StringBuilder sb;

        // Use this for initialization
        public StringHandler()
        {
            //Create a String builder with a current size of
            //1024 and max capacity of 1024
            sb = new StringBuilder(MAX_DEFAUL_SIZE, MAX_DEFAUL_SIZE);
        }

        public StringHandler(int size)
        {
            //Create a string builder with the size passed in
            sb = new StringBuilder(size, size);
        }

        //Various Add Text methods
        public void AddText(string s)
        {
            sb.Append(s);
        }

        public void AddText(int i)
        {
            sb.Append(i);
        }

        public void AddText(float f)
        {
            sb.Append(f);
        }

        public void AddText(char c)
        {
            sb.Append(c);
        }

        public void AddText(bool b)
        {
            sb.Append(b);
        }

        //Clears the string
        public void Clear()
        {
            sb.Length = 0;
        }

        //retrieve the string
        public string GetString()
        {
            return sb.ToString();
        }
    }
}
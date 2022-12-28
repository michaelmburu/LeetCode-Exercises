using System;
namespace LeetCode50Exercises
{
    public class ReadNCharacters
    {
        /*
         * Read 4 characters at a time from a file using read4 API
        */
        public int ReadNCharacters(char[] buf, int n)
        {
            char[] buffer = new char[4];
            int readBytes = 0;
            bool eof = false;
            while(!eof && readBytes < n)
            {
                int sz = read4(buffer);
                if (sz < 4) eof = true;
                int bytes = Math.Min(n - readBytes, sz);
                readBytes += bytes;
            }

            return readBytes;
        }

    }
}


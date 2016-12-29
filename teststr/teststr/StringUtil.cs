using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace teststr
{
    class StringUtil
    {
        public string txt;
        public StringUtil(string str)
        {
            txt = str;
        }
        public StringUtil()
        { }
        public string Reverse()
        {
            string res="";
            char[] txtt = txt.ToCharArray();
            for (int i = txtt.Length - 1; i >= 0; i--)
            {
                res += txtt[i];
            }
            return res;
        }
        public string Reverse(string text)
        {
            string res = "";
            char[] txtt = text.ToCharArray();
            for (int i = txtt.Length - 1; i >= 0; i--)
            {
                res += txtt[i];
            }
            return res;
        }
        public int Countchars()
        {
            
            return txt.ToCharArray().Length;
        }
        public int Countchars(string text)
        {

            return text.ToCharArray().Length;
        }
        public int Countspaces()
        {
            int r = 0;
            char[] tt = txt.ToCharArray();
            foreach (var item in tt)
            {
                if (item == ' ')
                {
                    r++;
                }
            }
            return r;
        }
        public int Countspaces(string text)
        {
            int r = 0;
            char[] tt = text.ToCharArray();
            foreach (var item in tt)
            {
                if (item == ' ')
                {
                    r++;
                }
            }
            return r;
        }
        public int Countwithoutspaces()
        {
            int r = 0;
            char[] tt = txt.ToCharArray();
            foreach (var item in tt)
            {
                if (item != ' ')
                {
                    r++;
                }
            }
            return r;
        }
        public int Countwithoutspaces(string text)
        {
            int r = 0;
            char[] tt = text.ToCharArray();
            foreach (var item in tt)
            {
                if (item != ' ')
                {
                    r++;
                }
            }
            return r;
        }
    }
}

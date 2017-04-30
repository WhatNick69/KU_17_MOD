﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace KU_17_WIN_MOD
{
    internal class Controller
    {
        Random rnd = new Random();
        public List<string> TextDebug = new List<string>();
        public bool Beta = false; //only for debug and beta versions//TODO
        public Stopwatch Sw = new Stopwatch();
        public int NumChars;
        public int Numtrue;
        private readonly ReplaceOrAnd _replace = new ReplaceOrAnd();
        private readonly GreedyAlgorithm _greedyAlgorithm = new GreedyAlgorithm();
        private readonly RandomAlgorithm _randomAlgorithm = new RandomAlgorithm();
        private readonly BruteAlgorithm _bruteAlgorithm = new BruteAlgorithm();
        private readonly DPLLAlgorithm _dllAlgorithm = new DPLLAlgorithm();
        List<string> resultList = new List<string>();

        internal List<string> InitBrute(string input, bool onlyFirstData)
        {
            Numtrue = 0;
            Sw.Reset();
            Sw.Start();
            string[] local = input.Split(new[] { ' ', '|', '&', '-' }, StringSplitOptions.RemoveEmptyEntries);
            
            resultList = _bruteAlgorithm.initAlgorithm(local, onlyFirstData, input); // решение жадным методом
            Numtrue = resultList.Count; 
            Sw.Stop();
            return resultList;
        }

        internal List<string> InitGreedy(string input, bool onlyFirstData)
        {
            string[] local = input.Split(new[] { ' ', '|', '&', '-' }, StringSplitOptions.RemoveEmptyEntries);
            int numresults = _bruteAlgorithm.initAlgorithm(local, onlyFirstData, input).Count;
            
            Sw.Reset();
            Sw.Start();
            
            List<string> resultList = new List<string>();

            string local2 = input.Replace(" ", "").Replace("^", ",").Replace("v", ".");

            resultList = _greedyAlgorithm.GreedyMethod(local2, onlyFirstData, numresults); // решение жадным методом

            Numtrue = resultList.Count;
            Sw.Stop();
            return resultList;
        }

        internal List<string> InitRandom(string input, bool onlyFirstData)
        {
            //_randomAlgorithm.RandomMethod(local2); // решение жадным методом
            Numtrue = 0;
            Sw.Reset();
            Sw.Start();
            string[] local = input.Split(new[] { ' ', '|', '&', '-' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> resultList = new List<string>();
            Dictionary<string, int> letternum = new Dictionary<string, int>();
            List<string> usedComb = new List<string>();

            int count = 0;
            foreach (string t in local)
            {
                if (letternum.ContainsKey(t)) continue;
                letternum.Add(t, count);
                count++;
            }

            NumChars = letternum.Count;
            char[] actualComb = new char[NumChars];
            int ses = new Combinations().Combine(NumChars).Count;

            while (usedComb.Count < ses)
            {
                string comb;
                do
                {
                    comb = "";
                    for (int i = 0; i < NumChars; i++)
                    {
                        actualComb[i] = rnd.Next(0, 2) == 0 ? '0' : '1';
                        comb += actualComb[i].ToString();
                    }
                    if (!usedComb.Contains(comb))
                    {
                        break;
                    }
                } while (usedComb.Count < ses);

                usedComb.Add(comb);

                string local3 = input.Replace(" ", "").Replace("^", ",").Replace("v", ".");
                string tempstring = "";
                foreach (KeyValuePair<string, int> i in letternum)
                {
                    int ubicacoin = letternum[i.Key];
                    string resulado = actualComb[ubicacoin].ToString();
                    local3 = local3.Replace(i.Key, resulado);
                    tempstring += i.Key + "=" + resulado + ", ";
                }

                bool resultad = ReplaceOrAnd.WorkWithOrAndV2(local3);

                if (resultad)
                {
                    resultList.Add(tempstring + ": " + resultad);
                    Numtrue++;
                    if (onlyFirstData) break;
                }
            }

            Sw.Stop();
            return resultList;
        }

        internal List<string> InitDPLL(string input, bool onlyFirstData)
        {
            Numtrue = 0;
            Sw.Reset();
            Sw.Start();
            string[] local = input.Split(new[] { ' ', '|', '&', '-' }, StringSplitOptions.RemoveEmptyEntries);

            if (onlyFirstData)
            {
            resultList = _dllAlgorithm.DPLLMethodFirstData(local, input); // решение жадным методом    
            }
            else
            {
                resultList = _dllAlgorithm.DPLLMethodAllData(local, input); // решение жадным методом
                
            }
            

            Numtrue = resultList.Count;
            Sw.Stop();
            return resultList;
        }
    }
}

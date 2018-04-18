using Frontend.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Repos
{
    public class Repo : IRepo
    {
        private LogContext context;

        public Repo(LogContext context)
        {
            this.context = context;
        }

        public List<Log> List()
        {
           
            return context.Logs.ToList();

        }

        public void Save(string endPoint, string data)
        {
            context.Logs.Add(new Log {
                EndPoint = endPoint,
                Data = data
            });
            context.SaveChanges();
        }
        public string TransformToYoda(string text)
        {
            List<string> switchedWords = new List<string>();
            string[] sentences = text.ToLower().Split(".");
            for (int i = 0; i < sentences.Length; i++)
            {
                string[] words = sentences[i].Split(" ");
                List<string> wordsList = words.ToList();
                for (int j = 0; j < wordsList.Count; j++)
                {
                    if (j == wordsList.Count - 1)
                    {
                        switchedWords.Add(words[j]);
                    }
                    if (j % 2 == 0 && j < wordsList.Count - 1)
                    {
                        switchedWords.Add(words[j + 1]);
                    }
                    if (j % 2 != 0 && j < wordsList.Count)
                    {
                        switchedWords.Add(words[j - 1]);
                    }
                }
          

            }

            string switchedSentence = null;
            for (int i = 0; i < switchedWords.Count; i++)
            {
                if (i == switchedWords.Count - 1)
                {
                    switchedSentence += switchedWords[i] + ".";
                }
                else
                {
                    switchedSentence += switchedWords[i] + " ";
                }

            }
            return switchedSentence;
        }
    }
}

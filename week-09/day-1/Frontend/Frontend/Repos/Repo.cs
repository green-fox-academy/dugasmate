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
            string[] words = sentences[0].Split(" ");
            List<string> wordsList = words.ToList();
            for (int i = 0; i < wordsList.Count; i++)
            {
                if (i == wordsList.Count - 1)
                {
                    switchedWords.Add(words[i]);
                }
                if (i % 2 == 0 && i < wordsList.Count - 1)
                {
                    switchedWords.Add(words[i+1]);
                }
                if (i % 2 != 0 && i < wordsList.Count)
                {
                    switchedWords.Add(words[i - 1]);
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

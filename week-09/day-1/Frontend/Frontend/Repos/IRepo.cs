using Frontend.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Repos
{
    public interface IRepo
    {
       void Save(string endPoint, string data);
        List<Log> List();
        string TransformToYoda(string text);
    }
}

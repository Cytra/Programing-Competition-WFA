using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using ProgramingCompetitionLibrary.Models;


namespace ProgramingCompetitionLibrary
{
    public static class TextConnectorProcessor
    {
        public static string FullFilepath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }

        public static List<TaskModel> ConvertToTaskModel(this List<string> lines)
        {
            List<TaskModel> output = new List<TaskModel>();
            foreach (var line in lines)
            {
                string[] cols = line.Split(',');

                TaskModel p = new TaskModel();
                p.ID = int.Parse(cols[0]);
                p.TaskName = cols[1];
                p.TaskDescribtion = cols[2];
                p.TaskSolution = cols[3];
                output.Add(p);
            }

            return output;
        }
    }
}

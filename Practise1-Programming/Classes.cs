using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise1_Programming
{
    public class Project
    {
        public int Id { get; set; }
        public List<ProjectTask> ProjectTasks { get; set; } = new();
    }

    public class ProjectTask
    {
        public int Id { get; set; }


        public static Project operator +(Project project, ProjectTask projectTask)
        {
            project.ProjectTasks.Add(projectTask);
            return project;
        }
    }
}

﻿namespace Wincubate.CS10.Part1.Data.Employees
{
    public enum ProjectManagerLevel
    {
        AssociateJunior,
        ProjectLead,
        Senior,
        Chief
    }

    public class ProjectManager : Employee
    {
        public ProjectManagerLevel? Level { get; set; }
        public string Team { get; set; }
    }
}

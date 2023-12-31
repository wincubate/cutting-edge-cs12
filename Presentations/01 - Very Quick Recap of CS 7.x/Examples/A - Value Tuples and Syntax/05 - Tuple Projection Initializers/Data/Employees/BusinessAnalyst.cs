﻿namespace Wincubate.CS10.Part1.Data.Employees
{
    public enum BusinessAnalystLevel
    {
        AssociateJunior,
        Senior,
        Lead,
        Chief
    }

    public class BusinessAnalyst : Employee
    {
        public BusinessAnalystLevel? Level { get; set; }
        public int ItasCreated { get; set; }
    }
}

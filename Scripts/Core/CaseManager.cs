// CaseManager.cs

using System;
using System.Collections.Generic;
using System.Linq;

namespace DetectiveGameSuite.Scripts.Core
{
    public class CaseManager
    {
        // Properties
        public List<Case> Cases { get; private set; }

        public CaseManager()
        {
            Cases = new List<Case>();
        }

        // Method to add a case
        public void AddCase(Case newCase)
        {
            Cases.Add(newCase);
        }

        // Method to verify a solution
        public bool VerifySolution(int caseId, string solution)
        {
            var caseToCheck = Cases.FirstOrDefault(c => c.Id == caseId);
            if (caseToCheck != null)
            {
                return caseToCheck.Solution == solution;
            }
            return false;
        }

        // Class representing a Case
        public class Case
        {
            public int Id { get; set; }
            public string Description { get; set; }
            public string Solution { get; set; }

            public Case(int id, string description, string solution)
            {
                Id = id;
                Description = description;
                Solution = solution;
            }
        }
    }
}
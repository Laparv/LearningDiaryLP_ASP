using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningDiaryLP_ASP.Models
{
    public partial class Topic
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? TimeToMaster { get; set; }
        public int? TimeSpent { get; set; }
        public string Source { get; set; }
        public DateTime? StartLearningDate { get; set; }
        public bool? InProgress { get; set; }
        public DateTime? CompletionDate { get; set; }


        public bool? IsInProgress()
        {
            if (TimeToMaster - TimeSpent <= 0)
            {
                InProgress = false;
            }
            else
            {
                InProgress = true;
            }

            return InProgress;
        }

        public DateTime? EditCompletionDate() //edits completion date to database
        {
            if (TimeToMaster - TimeSpent <= 0)
            {
                CompletionDate = Convert.ToDateTime(StartLearningDate).AddDays(Convert.ToDouble(TimeSpent));
            }
            else if (TimeToMaster - TimeSpent > 0)
            {
                CompletionDate = Convert.ToDateTime(StartLearningDate).AddDays(Convert.ToDouble(TimeToMaster));
            }

            return CompletionDate;

        }
    }
}


﻿using System.ComponentModel.DataAnnotations;

namespace trackingApi.Models
{
    public enum Priority
    {
        Low, Meduim, High
    }

    public enum IssueType
    {
        Feature,Bug,Documentation
    }


    public class Issue
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get;set; }

        public Priority Priority { get; set; }

        public IssueType IssueType { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Completed { get; set; }
    }
}

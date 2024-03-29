﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrainWave.NonEFModels
{
    public class BrainWaveCourseUpload
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public string CourseEstimatedTime { get; set; }
        public string CourseAuthor { get; set; }
        public List<BrainWaveCourseStepUpload> CourseSteps { get; set; }
    }
}
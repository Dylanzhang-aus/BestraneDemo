using System;
namespace BestraneDemo.Models
{
    public class Enrollment
    {
        public long Id { get; set; }
        public int Year { get; set; }
        public long StudentId { get; set; }

        public Enrollment()
        {
        }
    }
}

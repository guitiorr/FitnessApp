//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FitnessApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trainer
    {
        public string trainerId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public Nullable<double> Weight { get; set; }
        public Nullable<double> Height { get; set; }
        public byte[] ProfilePicture { get; set; }
        public string FullName { get; set; }
    }
}

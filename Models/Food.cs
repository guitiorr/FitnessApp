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
    
    public partial class Food
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Food()
        {
            this.UserFoodSchedules = new HashSet<UserFoodSchedule>();
        }
    
        public string FoodId { get; set; }
        public int Kcal { get; set; }
        public int Fat { get; set; }
        public int Carbs { get; set; }
        public int Sugar { get; set; }
        public byte[] FoodPicture { get; set; }
        public int Protein { get; set; }
        public string FoodName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserFoodSchedule> UserFoodSchedules { get; set; }
    }
}

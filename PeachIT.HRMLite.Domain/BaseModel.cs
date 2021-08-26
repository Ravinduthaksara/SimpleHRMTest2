using System;


namespace PeachIT.HRMLite.Domain
{
    public class BaseModel 
    {
        public BaseModel()
        {
            IsActive = false;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public int Id { get; set; }
        public Boolean IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}


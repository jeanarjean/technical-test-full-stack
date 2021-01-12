namespace TechnicalTest.Project.Domain
{
    public class HealthFacilityService: BaseEntity
    { 
        public HealthFacility HealthFacility { get; set; }

        public string HealthFacilityId { get; set; }
        
        public Service Service { get; set; }

        public string ServiceId { get; set; }
    }
}
using System.Collections.Generic;

namespace TechnicalTest.Project.Domain
{
    public class Service : BaseEntity
    {
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public IEnumerable<HealthFacilityService> HealthFacilityServices { get; set; }
        
        public IEnumerable<PractitionerService> PractitionerServices { get; set; }
    }
}
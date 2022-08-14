namespace MediatrAndCQRSDemo.Entities
{
    public class PersonalInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly DoB { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsNew { get; set; }
        //public EducationalInfo EducationalInfo { get; set; }
    }
}

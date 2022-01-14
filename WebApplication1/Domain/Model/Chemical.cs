namespace HectreMgmt.Domain.Model
{
    public class Chemical : BaseEntity<string>
    {
        public string chemicalType { get; set; }
        public string preHarvestIntervalInDays { get; set; }
        public string activeIngredient { get; set; }
        public string name { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime modificationDate { get; set; }
        public DateTime deletionDate { get; set; }
    }



}

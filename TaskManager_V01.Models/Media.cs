using TaskManager_V01.CustomTypes;

namespace TaskManager_V01.Models
{ 
    public class Media
    {
        public int MediaId { get; set; }
        public required int TaskID { get; set; }
        public required Task Task { get; set; }
        public required string ResourceURL { get; set; }
        public string MediaType { get; set; } = MediaTypes.Image;
    } 
}

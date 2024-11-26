using TaskManager_V01.CustomTypes;

namespace TaskManager_V01.Models
{
    public class Medias
    {
        public int MediaId { get; set; }
        public required Task Task { get; set; }
        public required string ResourceURL { get; set; }
        public string MediaType { get; set; } = MediaTypes.Image;
        public ICollection<Tasks> Tasks { get; set; } = [];
    }
}

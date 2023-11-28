namespace E_Learning.API.Model;
public class Lesson
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string YoutubeVideoPath { get; set; }
    public List<Content>? Contents { get; set; }
}

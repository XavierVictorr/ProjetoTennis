using System.ComponentModel.DataAnnotations;

namespace DOmain;

public abstract class BaseEntity 
{ 
    [Key]
    public Guid Id { get; set; }

    private DateTime? _creatAt;
    public DateTime? CreatAt
    {
        get { return _creatAt;}
        set { _creatAt = (value == null ? DateTime.UtcNow : value); }
    } 
    public DateTime? UpDateAt { get; set; }
}
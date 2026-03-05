using System;

public class Notification
{
    public Guid Id { get; init; }
    public string Title { get; set; }
    public string Message { get; set; }
    public DateTime CreatedAt { get; init; }
    public bool IsRead { get; private set; }

    public Notification(string title, string message)
    {
        Id = Guid.NewGuid();
        Title = title ?? string.Empty;
        Message = message ?? string.Empty;
        CreatedAt = DateTime.UtcNow;
        IsRead = false;
    }

    public void MarkAsRead()
    {
        IsRead = true;
    }

    public override string ToString()
    {
        return $"[{(IsRead ? 'R' : 'U')}] {Title} - {Message} (Created: {CreatedAt:O})";
    }
}



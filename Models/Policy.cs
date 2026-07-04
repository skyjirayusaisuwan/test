using System;

public class Policy
{
    public Guid Id { get; set; }
    public string PolicyType { get; set; }
    public Vehicle Vehicle { get; set; }
    public DateTime CreatedAt { get; set; }
    // สังเกตว่ายังไม่มีฟิลด์ RequiresManualInspection
}
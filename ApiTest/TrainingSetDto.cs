namespace ApiTest;

public class TrainingSetDto
{
    public long? Id { get; set; }
    public long TrainingExerciseId { get; set; }
    public List<long> TagIds { get; set; } = new List<long>();
    public TimeSpan CreationTime { get; set; }
    public bool IsSuperSet { get; set; } = false;
    public bool IsDropSet { get; set; } = false;
    public int? PauseMilliseconds { get; set; }
    public int? RepCount { get; set; }
    public float? WeightLiftedKilograms { get; set; }
    public float? DurationSeconds { get; set; }
    public float? DistanceMeters { get; set; }
    public int? UsedEquipmentId { get; set; }
    public byte? ResistanceBandId { get; set; }

    //pause data
    public List<DateTime> PauseRange = new List<DateTime>(2);
}
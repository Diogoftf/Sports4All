namespace Sports4All
{
    public interface IParkEvaluation
    {
        Park Park { get; set; }
        int ParkId { get; set; }
        int Price { get; set; }
        int Quality { get; set; }
    }
}
namespace FtpApp
{
    public class ProgressInformation
    {
        public int Progress { get; }
        public double TransferRate { get; }
        public long EstimatedTime { get;}
        public long Downloaded { get; }
        public long Total { get; }

        public ProgressInformation(long total, long downloaded, long elapsed)
        {
            Total = total;
            Progress = (int)(100 * (double)downloaded / total);
            TransferRate = elapsed == 0 ? 0 : downloaded / elapsed;
            EstimatedTime = TransferRate == 0 ? 0 : (long)((total - downloaded) / TransferRate);
            Downloaded = downloaded;
        }
    }
}
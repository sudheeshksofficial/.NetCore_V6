namespace UpgradedConsole
{
    internal class Railway
    {
        public int TrainId { get; set; }

        public int TrainNumber { get; set; }

        public string? TrainName { get; set; }

        public DateTime TrainStartDate { get; set; }

        public DateTime TrainEndDate { get; set; }

        public string? Schedule { get; set; }

        public Railway(int tempid, int tempNumber, string tempName, DateTime start, DateTime end, string tempschedule)
        {
            TrainId = tempid;
            TrainNumber = tempNumber;
            TrainName = tempName; TrainStartDate = start; TrainEndDate = end; Schedule = tempschedule;
        }

        public Railway()
        {

        }


    }


}

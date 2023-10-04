using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpgradedConsole
{
    class Subclass
    {
        internal void Operation(List<Railway> _railwayObjectList)
        {
            Subclass subclass = new();
            int count = 0;
            while (count == 0)
            {
                Console.WriteLine("enter the operation you want to choose : ");
                Console.WriteLine("1.get all trains \t 2.get train by id \t 3.update train name \t 4.delete train \t 5.add new train");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        subclass.getTrains(_railwayObjectList);
                        break;
                    case 2:
                        Console.Write("enter the id to search : ");
                        int nom = int.Parse(Console.ReadLine());
                        subclass.getByID(_railwayObjectList, nom);
                        break;
                    case 3:
                        subclass.editTrainName(_railwayObjectList);
                        break;
                    case 4:
                        subclass.removeTrain(_railwayObjectList);
                        break;
                    case 5:
                        subclass.addTrain(_railwayObjectList);
                        break;
                    default:
                        break;
                }
                Console.WriteLine("if again then give value 0");
                count = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Thanks for reaching us!!!!");

        }

        public void getTrains(List<Railway> _railwayObjectList)
        {
            foreach (var items in _railwayObjectList)
            {
                Console.WriteLine("train id :{0} || train number :{1} ||train name :{2} || train Starting date :{3} ||train Ending date :{4} ||train Schedule (weekly/weekends) :{5}", items.TrainId, items.TrainNumber, items.TrainName, items.TrainStartDate, items.TrainEndDate, items.Schedule);
            }

        }

        public void getByID(List<Railway> _railwayObjectList, int num)
        {
            var firstor = _railwayObjectList.FirstOrDefault(x => x.TrainId == num);
            var opt = _railwayObjectList.Find(x => x.TrainId == num);
            var listing = _railwayObjectList.Where(x => x.TrainId == num);
            Console.WriteLine(opt + "           " + listing + "         " + firstor);
            foreach (var items in listing)
            {
                Console.WriteLine("train id :{0} || train number :{1} ||train name :{2} || train Starting date :{3} ||train Ending date :{4} ||train Schedule (weekly/weekends) :{5}", items.TrainId, items.TrainNumber, items.TrainName, items.TrainStartDate, items.TrainEndDate, items.Schedule);

            }

        }

        public void editTrainName(List<Railway> _railwayObjectList)
        {
            Console.WriteLine("Enter the new train name : ");
            string name = Console.ReadLine();
            Console.WriteLine("enter new train name : ");
            string newname = Console.ReadLine();
            var item = _railwayObjectList.Find(x => x.TrainName == name);
            item.TrainName = newname;
            Console.WriteLine("updated successfully !!!");

        }

        public void removeTrain(List<Railway> _railwayObjectList)
        {
            Console.WriteLine("enter the train id you wish to remove : ");
            int id = int.Parse(Console.ReadLine());
            var item = _railwayObjectList.Find(x => x.TrainId == id);
            _railwayObjectList.Remove(item);
        }

        public void addTrain(List<Railway> _railwayObjectList)
        {
            Console.WriteLine("train id : ");
            int tempid = int.Parse(Console.ReadLine());
            Console.WriteLine("train number : ");
            int tempNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter trian name : ");
            string? tempName = Console.ReadLine();
            Console.WriteLine("Train start date : ");
            DateTime start = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Train end date : ");
            DateTime end = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter scheduling name : ");
            string? tempschedule = Console.ReadLine();
            _railwayObjectList.Add(new Railway(tempid, tempNumber, tempName, start, end, tempschedule));

            Console.WriteLine("added successfully");

        }

    }
}

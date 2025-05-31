using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Death_by_System
{
    internal class DataStorage
    {
        public static Queue<StageResult> stageResult = new Queue<StageResult>();
        public static List<GameContentCompilation> gameHistory = new List<GameContentCompilation>()
        {
            new GameContentCompilation("Lyndon",75.8),
            new GameContentCompilation("Mark",83.5),
            new GameContentCompilation("Joms",69.1),
            new GameContentCompilation("Eddh",69.3),
            new GameContentCompilation("Jayniell",77.4),
            new GameContentCompilation("XxEddhxX",54.7)
        };
        public static List<DataSetRecord> survivalList = new List<DataSetRecord>();
    }
}

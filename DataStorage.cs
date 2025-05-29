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
        public static List<GameContentCompilation> gameHistory = new List<GameContentCompilation>();
    }
}

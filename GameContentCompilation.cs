using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Data;
using System.Reflection;

namespace Death_by_System
{

   
    public class GameContentCompilation
    {
        private string PlayerName;
        private float AverageSC;
        public GameContentCompilation(string playerName, float averageSC) 
        {
            PlayerName = playerName; 
            AverageSC = averageSC;
        }

     
    }

  
    public class StageResult
    {
        private string PlayerCharacter;
        private float SurvivalChance;
        public StageResult(string playerCharacter, float survivalChance)
        {
            PlayerCharacter = playerCharacter;
            SurvivalChance = survivalChance;
        }

        public string GetPlayerCharacter()
        {
            return PlayerCharacter;
        }
        public float GetSurvivalChance()
        {
            return SurvivalChance;
        }
    }
    public class GameContent 
    {
/*        string scenarioText = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                                  "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer " +
                                  "took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, " +
                                  "but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s " +
                                  "with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing " +
                                  "software like Aldus PageMaker including versions of Lorem Ipsum.";*/


        static string scene1 = "The support beams of the ancient mine shaft groan under immense pressure, threatening to collapse." +
                        "A massive, enraged earth elemental, unbreakable walls, blocks the only escape route, its rocky fists shattering stone. " +
                        "Trapped miners cry for help, their oxygen dwindling. The air is thick with dust, limiting visibility. " +
                        "Direct confrontation is unavoidable, but survival depends on swift, decisive action. Which class is most crucial for success?";

        static string scene2 = "An ancient, cursed library holds a powerful artifact, but its halls are filled with spectral guardians that drain sanity with their whispers." +
                        "Runes glow faintly on the floor, shifting unpredictably, and illusions distort reality. A forgotten language must be deciphered to unlock the artifact's protective seals. " +
                        "The air is cold, filled with despair, and the path forward is a maze of arcane traps. Which class is most crucial for success?";

        static string scene3 = "A corrupt Baron holds a vital ledger detailing his illicit activities, hidden within his heavily guarded manor during a grand gala." +
                        " Direct assault is impossible due to overwhelming security and noble guests. The ledger is in a locked strongbox in his private study, guarded by patrols and magical alarms." +
                        "The mission requires precise lockpicking, and swift extraction without alerting anyone. Which class is most crucial for success?";
        public static string GetScenesText(string input) 
        {
            Dictionary<string, string> gameScenes = new Dictionary<string, string>
            {
                { "Whisperwood Forest", scene1 },
                { "Cursed Ashland", scene2 },
                { "Volcanic Wasteland", scene3 }
            };

            return gameScenes[input];
        }  
    }

    public class DataSetRecord
    {
        public string CharacterClass { get; set; }
        public double SurvivalChance { get; set; }
    }

    class DataSetRanking
    {
        public static string GetRanking(float score)
        {

            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataSet", "CharacterStatsDataSet.csv");


            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
            }))
            {
                DataStorage.survivalList = csv.GetRecords<DataSetRecord>().ToList();
            }

            QuickSort(DataStorage.survivalList, 0, DataStorage.survivalList.Count - 1);
            return GetPercentile(FindPercentileIndex(DataStorage.survivalList, score));
        }

        public static void PercentileView()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataSet", "CharacterStatsDataSet.csv");


            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
            }))
            {
                DataStorage.survivalList = csv.GetRecords<DataSetRecord>().ToList();
            }

            QuickSort(DataStorage.survivalList, 0, DataStorage.survivalList.Count - 1);
            int total = DataStorage.survivalList.Count;
            //int total = 100;

            int top1PercentCount = (int)Math.Floor(total * 0.01);
            int top5PercentCount = (int)Math.Floor(total * 0.05);
            int top20PercentCount = (int)Math.Floor(total * 0.20);
            int top50PercentCount = (int)Math.Floor(total * 0.50);


            string text = "Top 1%\n";
            string text1 = "Top 5%\n";
            string text2 = "Top 20%\n";
            string text3 = "Top 50%\n";

            string text4 = "DataSet:\n";

            for (int i = 0; i < top1PercentCount; i++)
            {
                text += $"{DataStorage.survivalList[i].CharacterClass}: {DataStorage.survivalList[i].SurvivalChance}" + "\n";
            }



            for (int i = 0; i < top5PercentCount; i++)
            {
                text1 += $"{DataStorage.survivalList[i].CharacterClass}: {DataStorage.survivalList[i].SurvivalChance}" + "\n";
            }



            for (int i = 0; i < top20PercentCount; i++)
            {
                text2 += $"{DataStorage.survivalList[i].CharacterClass}: {DataStorage.survivalList[i].SurvivalChance}" + "\n";
            }

            for (int i = 0; i < top50PercentCount; i++)
            {
                text3 += $"{DataStorage.survivalList[i].CharacterClass}: {DataStorage.survivalList[i].SurvivalChance}" + "\n";
            }

            for (int i = 0; i < DataStorage.survivalList.Count; i++)
            {
                text4 += $"{DataStorage.survivalList[i].CharacterClass}: {DataStorage.survivalList[i].SurvivalChance}" + "\n";
            }

            MessageBox.Show(text + "\n" + text1 + "\n" + text2 + "\n" + text3 + "\n\n" + text4);
        }

        private static string GetPercentile(int index)
        {

            double percentile = ((double)(index + 1) / DataStorage.survivalList.Count) * 100;

            if (percentile <= 1)
            {
                return "Currently at Top 1% among all stats combination";
            }
            else if (percentile <= 5)
            {
                return "Currently at Top 5% among all stats combination";
            }
            else if (percentile <= 20)
            {
                return "Currently at Top 20% among all stats combination";
            }
            else if (percentile <= 50)
            {
                return "Currently at Top 50% among all stats combination";
            }
            else
            {
                return "";
            }

        }



        private static int FindPercentileIndex(List<DataSetRecord> sortedList, float target) 
        {

            int left = 0;
            int right = sortedList.Count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (sortedList[mid].SurvivalChance == target)
                {
                    return mid;
                }
                else if (sortedList[mid].SurvivalChance < target)
                {
                    right = mid - 1;
                }
                else 
                {
                    left = mid + 1;
                }
                    
            }

            return Math.Abs(sortedList[left].SurvivalChance - target) < Math.Abs(sortedList[right].SurvivalChance - target) ? left : right;
        }

        public static void QuickSort(List<DataSetRecord> dataList, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(dataList, low, high);
                QuickSort(dataList, low, pivotIndex - 1);
                QuickSort(dataList, pivotIndex + 1, high);
            }
        }

        private static int Partition(List<DataSetRecord> dataList, int low, int high)
        {
            var pivot = dataList[high].SurvivalChance;
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (dataList[j].SurvivalChance > pivot) // Descending order
                {
                    i++;
                    Swap(dataList, i, j);
                }
            }

            Swap(dataList, i + 1, high);
            return i + 1;
        }

        private static void Swap(List<DataSetRecord> dataList, int a, int b)
        {
            var temp = dataList[a];
            dataList[a] = dataList[b];
            dataList[b] = temp;
        }


    }

}

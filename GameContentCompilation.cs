using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    
}

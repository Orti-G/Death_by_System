using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;



namespace Death_by_System
{
    public partial class GamePlay : UserControl
    {
        public static string predictedClass;
        public static float predictedSurvivalChance;
        public class PredictionResult
        {
            [JsonProperty("PredictedClass")]
            public string PredictedClass { get; set; }

            [JsonProperty("SurvivalChance")]
            public float SurvivalChance { get; set; }
        }

        private int PlayerPoints = 100;

        public GamePlay()
        {
            InitializeComponent();
        }

        private void GamePlay_Load(object sender, EventArgs e)
        {
            lblPoints.Text = PlayerPoints.ToString();
        }

        private async void btnCommit_Click(object sender, EventArgs e)
        {
            await CallPredictionAPIAsync();


            StatsPanel.Controls.Clear();

            CharacterSurvivalChance survivalControl = new CharacterSurvivalChance();
            survivalControl.Dock = DockStyle.Fill;
            StatsPanel.Controls.Add(survivalControl);

            survivalControl.StartRevealSequence();

        }

        private async Task<PredictionResult> CallPredictionAPIAsync()
        {
            var input = new
            {
                Power = float.Parse(txtBoxPower.Text),
                Focus = float.Parse(txtBoxFocus.Text),
                Agility = float.Parse(txtBoxAgility.Text),
                Resilience = float.Parse(txtBoxResilience.Text),
                Energy = float.Parse(txtBoxEnergy.Text),
                Intuition = float.Parse(txtBoxIntuition.Text)
            };

            using var client = new HttpClient();
            var json = JsonConvert.SerializeObject(input);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("http://localhost:5000/predict", content);
            string result = await response.Content.ReadAsStringAsync();

            // DEBUG: inspect response
            if (!response.IsSuccessStatusCode || result.TrimStart().StartsWith("<"))
            {
                MessageBox.Show("Server error or not JSON. Check your API.");
                return null;
            }

            var prediction = JsonConvert.DeserializeObject<PredictionResult>(result);
            predictedClass = prediction.PredictedClass;
            predictedSurvivalChance = prediction.SurvivalChance;
            DataStorage.stageResult.Enqueue(new StageResult(predictedClass,predictedSurvivalChance));  
            
            return prediction;
        }

        public async void StartRevealSequence(string scenario)
        {
            // Step 1: Hide all elements initially
            StatsPanel.Visible = false;
            panel_Title.Visible = false;
            panel_Scenario.Visible = false;
            label_Scenario.Visible = false;
            label_textScenario.Visible = false;

            // Step 2: Reveal panel_Title after 1 second
            await Task.Delay(1000);
            panel_Title.Visible = true;

            // Step 3: Reveal panel_Scenario after another second
            await Task.Delay(1000);
            panel_Scenario.Visible = true;

            // Step 4: Reveal label_Scenario after another second
            await Task.Delay(1000);
            label_Scenario.Visible = true;

            // Step 5: Hide label_Scenario, then start typing into label_textScenario
            await Task.Delay(1000);
            label_Scenario.Visible = false;
            label_textScenario.Text = "";
            label_textScenario.Visible = true;

            string scenarioText = scenario;

            // Typing animation: type one character at a time
            foreach (char c in scenarioText)
            {
                label_textScenario.Text += c;
                //await Task.Delay(10); // Adjust typing speed here (10 ms per char)
            }

            // Step 6: Once typing is complete, reveal StatsPanel
            await Task.Delay(500); // Optional pause after typing
            StatsPanel.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBoxPower_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtBoxPower.Text) < 0)
                {
                    MessageBox.Show("Invalid Input");
                    txtBoxPower.Focus();
                }
                else if (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text)) < 0)
                {
                    MessageBox.Show("Insufficient points");
                    txtBoxPower.Focus();
                }
                else
                {
                    lblPoints.Text = (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text))).ToString();
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Invalid Input");
                txtBoxPower.Focus();
            }

        }

        private void txtBoxFocus_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtBoxFocus.Text) < 0)
                {
                    MessageBox.Show("Invalid Input");
                    txtBoxFocus.Focus();
                }
                else if (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text)) < 0)
                {
                    MessageBox.Show("Insufficient points");
                    txtBoxFocus.Focus();
                }
                else
                {
                    lblPoints.Text = (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text))).ToString();
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Invalid Input");
                txtBoxFocus.Focus();
            }
        }

        private void txtBoxAgility_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtBoxAgility.Text) < 0)
                {
                    MessageBox.Show("Invalid Input");
                    txtBoxAgility.Focus();
                }
                else if (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text)) < 0)
                {
                    MessageBox.Show("Insufficient points");
                    txtBoxAgility.Focus();
                }
                else
                {
                    lblPoints.Text = (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text))).ToString();
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Invalid Input");
                txtBoxAgility.Focus();
            }
        }

        private void txtBoxResilience_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtBoxResilience.Text) < 0)
                {
                    MessageBox.Show("Invalid Input");
                    txtBoxResilience.Focus();
                }
                else if (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text)) < 0)
                {
                    MessageBox.Show("Insufficient points");
                    txtBoxResilience.Focus();
                }
                else
                {
                    lblPoints.Text = (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text))).ToString();
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Invalid Input");
                txtBoxResilience.Focus();
            }
        }

        private void txtBoxEnergy_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtBoxEnergy.Text) < 0)
                {
                    MessageBox.Show("Invalid Input");
                    txtBoxEnergy.Focus();
                }
                else if (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text)) < 0)
                {
                    MessageBox.Show("Insufficient points");
                    txtBoxEnergy.Focus();
                }
                else
                {
                    lblPoints.Text = (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text))).ToString();
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Invalid Input");
                txtBoxEnergy.Focus();
            }
        }

        private void txtBoxIntuition_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtBoxIntuition.Text) < 0)
                {
                    MessageBox.Show("Invalid Input");
                    txtBoxIntuition.Focus();
                }
                else if (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text)) < 0)
                {
                    MessageBox.Show("Insufficient points");
                    txtBoxIntuition.Focus();
                }
                else
                {
                    lblPoints.Text = (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text))).ToString();
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Invalid Input");
                txtBoxIntuition.Focus();
            }
        }

        private void btnAddPower_Click(object sender, EventArgs e)
        {
            if (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text) + 1) < 0)
            {
                MessageBox.Show("Insufficient points");
            }
            else
            {
                txtBoxPower.Text = (Convert.ToInt32(txtBoxPower.Text) + 1).ToString();
                lblPoints.Text = (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text))).ToString();
            }
        }

        private void btnMinusPower_Click(object sender, EventArgs e)
        {
            if (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text) - 1) > 100)
            {
                MessageBox.Show("Out of bounds");
            }
            else
            {
                txtBoxPower.Text = (Convert.ToInt32(txtBoxPower.Text) - 1).ToString();
                lblPoints.Text = (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text))).ToString();
            }
        }

        private void btnAddFocus_Click(object sender, EventArgs e)
        {
            if (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text) + 1) < 0)
            {
                MessageBox.Show("Insufficient points");
            }
            else
            {
                txtBoxFocus.Text = (Convert.ToInt32(txtBoxFocus.Text) + 1).ToString();
                lblPoints.Text = (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text))).ToString();
            }
        }

        private void btnMinusFocus_Click(object sender, EventArgs e)
        {
            if (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text) - 1) > 100)
            {
                MessageBox.Show("Out of bounds");
            }
            else
            {
                txtBoxFocus.Text = (Convert.ToInt32(txtBoxFocus.Text) - 1).ToString();
                lblPoints.Text = (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text))).ToString();
            }
        }

        private void btnAddAgility_Click(object sender, EventArgs e)
        {
            if (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text) + 1) < 0)
            {
                MessageBox.Show("Insufficient points");
            }
            else
            {
                txtBoxAgility.Text = (Convert.ToInt32(txtBoxAgility.Text) + 1).ToString();
                lblPoints.Text = (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text))).ToString();
            }
        }

        private void btnMinusAgility_Click(object sender, EventArgs e)
        {
            if (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text) - 1) > 100)
            {
                MessageBox.Show("Out of bounds");
            }
            else
            {
                txtBoxAgility.Text = (Convert.ToInt32(txtBoxAgility.Text) - 1).ToString();
                lblPoints.Text = (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text))).ToString();
            }
        }

        private void btnAddResilience_Click(object sender, EventArgs e)
        {
            if (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text) + 1) < 0)
            {
                MessageBox.Show("Insufficient points");
            }
            else
            {
                txtBoxResilience.Text = (Convert.ToInt32(txtBoxResilience.Text) + 1).ToString();
                lblPoints.Text = (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text))).ToString();
            }
        }

        private void btnMinusResilience_Click(object sender, EventArgs e)
        {
            if (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text) - 1) > 100)
            {
                MessageBox.Show("Out of bounds");
            }
            else
            {
                txtBoxResilience.Text = (Convert.ToInt32(txtBoxResilience.Text) - 1).ToString();
                lblPoints.Text = (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text))).ToString();
            }
        }

        private void btnAddEnergy_Click(object sender, EventArgs e)
        {
            if (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text) + 1) < 0)
            {
                MessageBox.Show("Insufficient points");
            }
            else
            {
                txtBoxEnergy.Text = (Convert.ToInt32(txtBoxEnergy.Text) + 1).ToString();
                lblPoints.Text = (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text))).ToString();
            }
        }

        private void btnMinusEnergy_Click(object sender, EventArgs e)
        {
            if (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text) - 1) > 100)
            {
                MessageBox.Show("Out of bounds");
            }
            else
            {
                txtBoxEnergy.Text = (Convert.ToInt32(txtBoxEnergy.Text) - 1).ToString();
                lblPoints.Text = (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text))).ToString();
            }
        }

        private void btnAddIntuition_Click(object sender, EventArgs e)
        {
            if (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text) + 1) < 0)
            {
                MessageBox.Show("Insufficient points");
            }
            else
            {
                txtBoxIntuition.Text = (Convert.ToInt32(txtBoxIntuition.Text) + 1).ToString();
                lblPoints.Text = (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text))).ToString();
            }
        }

        private void btnMinusIntuition_Click(object sender, EventArgs e)
        {
            if (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text) - 1) > 100)
            {
                MessageBox.Show("Out of bounds");
            }
            else
            {
                txtBoxIntuition.Text = (Convert.ToInt32(txtBoxIntuition.Text) - 1).ToString();
                lblPoints.Text = (PlayerPoints - (Convert.ToInt32(txtBoxPower.Text) + Convert.ToInt32(txtBoxFocus.Text) + Convert.ToInt32(txtBoxAgility.Text) + Convert.ToInt32(txtBoxResilience.Text) + Convert.ToInt32(txtBoxEnergy.Text) + Convert.ToInt32(txtBoxIntuition.Text))).ToString();
            }
        }

        private void lblPoints_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}

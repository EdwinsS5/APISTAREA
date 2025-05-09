using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace WindowsFormsAPIApp
{
    public partial class MainForm : Form
    {
        private readonly HttpClient _httpClient;
        private string? lastPokemonInfo;

        public MainForm()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
        }

        private async void btnSearchPokemon_Click(object sender, EventArgs e)
        {
            string pokemonName = txtPokemonSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(pokemonName))
            {
                MessageBox.Show("Por favor, ingrese un nombre de Pokémon.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                lblPokemonInfo.Text = "Buscando...";
                string url = $"https://pokeapi.co/api/v2/pokemon/{pokemonName}";
                string response = await _httpClient.GetStringAsync(url);

                var pokemon = JObject.Parse(response);
                string info = $"ID: {pokemon["id"]}\n" +
                              $"Nombre: {pokemon["name"]}\n" +
                              $"Altura: {pokemon["height"]} decímetros\n" +
                              $"Peso: {pokemon["weight"]} hectogramos\n" +
                              $"Tipo(s): {string.Join(", ", pokemon["types"].Select(t => t["type"]["name"]))}";

                lblPokemonInfo.Text = info;
                lastPokemonInfo = info;

                string imageUrl = pokemon["sprites"]["front_default"].ToString();
                picPokemon.Load(imageUrl);
            }
            catch (Exception ex)
            {
                lblPokemonInfo.Text = "Error al buscar Pokémon.";
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSavePokemon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lastPokemonInfo))
            {
                MessageBox.Show("No hay información para guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivo JSON (*.json)|*.json|Archivo de texto (*.txt)|*.txt",
                Title = "Guardar información del Pokémon"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, lastPokemonInfo);
                    MessageBox.Show("Información guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClearPokemon_Click(object sender, EventArgs e)
        {
            txtPokemonSearch.Clear();
            lblPokemonInfo.Text = "Información Pokémon";
            picPokemon.Image = null;
            lastPokemonInfo = null;
        }

        private async void btnSearchCat_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://api.thecatapi.com/v1/images/search";
                string response = await _httpClient.GetStringAsync(url);

                var cat = JArray.Parse(response)[0];
                string imageUrl = cat["url"].ToString();

                picCat.Load(imageUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar imagen de gato: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
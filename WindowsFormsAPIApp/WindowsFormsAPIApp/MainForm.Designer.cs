namespace WindowsFormsAPIApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; de lo contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método requerido para admitir el Diseñador. No modifique
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPokemon = new System.Windows.Forms.TabPage();
            this.tabCats = new System.Windows.Forms.TabPage();
            this.txtPokemonSearch = new System.Windows.Forms.TextBox();
            this.btnSearchPokemon = new System.Windows.Forms.Button();
            this.btnSavePokemon = new System.Windows.Forms.Button();
            this.btnClearPokemon = new System.Windows.Forms.Button();
            this.lblPokemonInfo = new System.Windows.Forms.Label();
            this.picPokemon = new System.Windows.Forms.PictureBox();
            this.btnSearchCat = new System.Windows.Forms.Button();
            this.picCat = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabPokemon.SuspendLayout();
            this.tabCats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPokemon);
            this.tabControl.Controls.Add(this.tabCats);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 0;
            // 
            // tabPokemon
            // 
            this.tabPokemon.Controls.Add(this.txtPokemonSearch);
            this.tabPokemon.Controls.Add(this.btnSearchPokemon);
            this.tabPokemon.Controls.Add(this.btnSavePokemon);
            this.tabPokemon.Controls.Add(this.btnClearPokemon);
            this.tabPokemon.Controls.Add(this.lblPokemonInfo);
            this.tabPokemon.Controls.Add(this.picPokemon);
            this.tabPokemon.Location = new System.Drawing.Point(4, 24);
            this.tabPokemon.Name = "tabPokemon";
            this.tabPokemon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPokemon.Size = new System.Drawing.Size(792, 422);
            this.tabPokemon.TabIndex = 0;
            this.tabPokemon.Text = "Pokémon";
            this.tabPokemon.UseVisualStyleBackColor = true;
            // 
            // tabCats
            // 
            this.tabCats.Controls.Add(this.btnSearchCat);
            this.tabCats.Controls.Add(this.picCat);
            this.tabCats.Location = new System.Drawing.Point(4, 24);
            this.tabCats.Name = "tabCats";
            this.tabCats.Padding = new System.Windows.Forms.Padding(3);
            this.tabCats.Size = new System.Drawing.Size(792, 422);
            this.tabCats.TabIndex = 1;
            this.tabCats.Text = "Gatos";
            this.tabCats.UseVisualStyleBackColor = true;
            // 
            // txtPokemonSearch
            // 
            this.txtPokemonSearch.Location = new System.Drawing.Point(20, 20);
            this.txtPokemonSearch.Name = "txtPokemonSearch";
            this.txtPokemonSearch.PlaceholderText = "Ingrese nombre del Pokémon";
            this.txtPokemonSearch.Size = new System.Drawing.Size(200, 23);
            this.txtPokemonSearch.TabIndex = 0;
            // 
            // btnSearchPokemon
            // 
            this.btnSearchPokemon.Location = new System.Drawing.Point(230, 20);
            this.btnSearchPokemon.Name = "btnSearchPokemon";
            this.btnSearchPokemon.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPokemon.TabIndex = 1;
            this.btnSearchPokemon.Text = "Buscar";
            this.btnSearchPokemon.UseVisualStyleBackColor = true;
            this.btnSearchPokemon.Click += new System.EventHandler(this.btnSearchPokemon_Click);
            // 
            // btnSavePokemon
            // 
            this.btnSavePokemon.Location = new System.Drawing.Point(310, 20);
            this.btnSavePokemon.Name = "btnSavePokemon";
            this.btnSavePokemon.Size = new System.Drawing.Size(75, 23);
            this.btnSavePokemon.TabIndex = 2;
            this.btnSavePokemon.Text = "Guardar";
            this.btnSavePokemon.UseVisualStyleBackColor = true;
            this.btnSavePokemon.Click += new System.EventHandler(this.btnSavePokemon_Click);
            // 
            // btnClearPokemon
            // 
            this.btnClearPokemon.Location = new System.Drawing.Point(390, 20);
            this.btnClearPokemon.Name = "btnClearPokemon";
            this.btnClearPokemon.Size = new System.Drawing.Size(75, 23);
            this.btnClearPokemon.TabIndex = 3;
            this.btnClearPokemon.Text = "Limpiar";
            this.btnClearPokemon.UseVisualStyleBackColor = true;
            this.btnClearPokemon.Click += new System.EventHandler(this.btnClearPokemon_Click);
            // 
            // lblPokemonInfo
            // 
            this.lblPokemonInfo.AutoSize = true;
            this.lblPokemonInfo.Location = new System.Drawing.Point(20, 60);
            this.lblPokemonInfo.Name = "lblPokemonInfo";
            this.lblPokemonInfo.Size = new System.Drawing.Size(114, 15);
            this.lblPokemonInfo.TabIndex = 4;
            this.lblPokemonInfo.Text = "Información Pokémon";
            // 
            // picPokemon
            // 
            this.picPokemon.Location = new System.Drawing.Point(20, 100);
            this.picPokemon.Name = "picPokemon";
            this.picPokemon.Size = new System.Drawing.Size(200, 200);
            this.picPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPokemon.TabIndex = 5;
            this.picPokemon.TabStop = false;
            // 
            // btnSearchCat
            // 
            this.btnSearchCat.Location = new System.Drawing.Point(20, 20);
            this.btnSearchCat.Name = "btnSearchCat";
            this.btnSearchCat.Size = new System.Drawing.Size(75, 23);
            this.btnSearchCat.TabIndex = 0;
            this.btnSearchCat.Text = "Buscar";
            this.btnSearchCat.UseVisualStyleBackColor = true;
            this.btnSearchCat.Click += new System.EventHandler(this.btnSearchCat_Click);
            // 
            // picCat
            // 
            this.picCat.Location = new System.Drawing.Point(20, 60);
            this.picCat.Name = "picCat";
            this.picCat.Size = new System.Drawing.Size(200, 200);
            this.picCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCat.TabIndex = 1;
            this.picCat.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Explorador de Pokémon y Gatos";
            this.tabControl.ResumeLayout(false);
            this.tabPokemon.ResumeLayout(false);
            this.tabPokemon.PerformLayout();
            this.tabCats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPokemon;
        private System.Windows.Forms.TabPage tabCats;
        private System.Windows.Forms.TextBox txtPokemonSearch;
        private System.Windows.Forms.Button btnSearchPokemon;
        private System.Windows.Forms.Button btnSavePokemon;
        private System.Windows.Forms.Button btnClearPokemon;
        private System.Windows.Forms.Label lblPokemonInfo;
        private System.Windows.Forms.PictureBox picPokemon;
        private System.Windows.Forms.Button btnSearchCat;
        private System.Windows.Forms.PictureBox picCat;
    }
}
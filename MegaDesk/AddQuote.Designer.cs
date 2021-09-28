
namespace MegaDesk
{
    partial class AddQuote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.NumericUpDown();
            this.depthInput = new System.Windows.Forms.NumericUpDown();
            this.drawersInput = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.woodTypes = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.drawerLabel = new System.Windows.Forms.Label();
            this.buildDeskBtn = new System.Windows.Forms.Button();
            this.prodLabel = new System.Windows.Forms.Label();
            this.prod = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawersInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Your Desk!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(518, 134);
            this.widthInput.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthInput.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(100, 20);
            this.widthInput.TabIndex = 2;
            this.widthInput.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthInput.ValueChanged += new System.EventHandler(this.widthInput_ValueChanged);
            // 
            // depthInput
            // 
            this.depthInput.Location = new System.Drawing.Point(518, 188);
            this.depthInput.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depthInput.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(100, 20);
            this.depthInput.TabIndex = 3;
            this.depthInput.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthInput.ValueChanged += new System.EventHandler(this.depthInput_ValueChanged);
            // 
            // drawersInput
            // 
            this.drawersInput.Location = new System.Drawing.Point(518, 240);
            this.drawersInput.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawersInput.Name = "drawersInput";
            this.drawersInput.Size = new System.Drawing.Size(100, 20);
            this.drawersInput.TabIndex = 4;
            this.drawersInput.ValueChanged += new System.EventHandler(this.drawersInput_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.comboBox1.Location = new System.Drawing.Point(518, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // woodTypes
            // 
            this.woodTypes.AutoSize = true;
            this.woodTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.woodTypes.Location = new System.Drawing.Point(255, 84);
            this.woodTypes.Name = "woodTypes";
            this.woodTypes.Size = new System.Drawing.Size(133, 24);
            this.woodTypes.TabIndex = 7;
            this.woodTypes.Text = "Material Type: ";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(287, 134);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(68, 24);
            this.widthLabel.TabIndex = 8;
            this.widthLabel.Text = "Width: ";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(286, 184);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(70, 24);
            this.depthLabel.TabIndex = 9;
            this.depthLabel.Text = "Depth: ";
            // 
            // drawerLabel
            // 
            this.drawerLabel.AutoSize = true;
            this.drawerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerLabel.Location = new System.Drawing.Point(232, 234);
            this.drawerLabel.Name = "drawerLabel";
            this.drawerLabel.Size = new System.Drawing.Size(178, 24);
            this.drawerLabel.TabIndex = 10;
            this.drawerLabel.Text = "Number of Drawers:";
            // 
            // buildDeskBtn
            // 
            this.buildDeskBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildDeskBtn.Location = new System.Drawing.Point(243, 382);
            this.buildDeskBtn.Name = "buildDeskBtn";
            this.buildDeskBtn.Size = new System.Drawing.Size(393, 41);
            this.buildDeskBtn.TabIndex = 11;
            this.buildDeskBtn.Text = "Build My Desk!";
            this.buildDeskBtn.UseVisualStyleBackColor = true;
            this.buildDeskBtn.Click += new System.EventHandler(this.buildDeskBtn_Click);
            // 
            // prodLabel
            // 
            this.prodLabel.AutoSize = true;
            this.prodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodLabel.Location = new System.Drawing.Point(251, 284);
            this.prodLabel.Name = "prodLabel";
            this.prodLabel.Size = new System.Drawing.Size(141, 24);
            this.prodLabel.TabIndex = 12;
            this.prodLabel.Text = "Production time";
            // 
            // prod
            // 
            this.prod.FormattingEnabled = true;
            this.prod.Items.AddRange(new object[] {
            "14",
            "3",
            "5",
            "7"});
            this.prod.Location = new System.Drawing.Point(518, 289);
            this.prod.Name = "prod";
            this.prod.Size = new System.Drawing.Size(100, 21);
            this.prod.TabIndex = 13;
            this.prod.SelectedIndexChanged += new System.EventHandler(this.prod_SelectedIndexChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(251, 334);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(113, 24);
            this.nameLabel.TabIndex = 14;
            this.nameLabel.Text = "Your name: ";
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.Location = new System.Drawing.Point(518, 334);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 29);
            this.nameInput.TabIndex = 15;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.prod);
            this.Controls.Add(this.prodLabel);
            this.Controls.Add(this.buildDeskBtn);
            this.Controls.Add(this.drawerLabel);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.woodTypes);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.drawersInput);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.label1);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawersInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown widthInput;
        private System.Windows.Forms.NumericUpDown depthInput;
        private System.Windows.Forms.NumericUpDown drawersInput;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label woodTypes;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label drawerLabel;
        private System.Windows.Forms.Button buildDeskBtn;
        private System.Windows.Forms.Label prodLabel;
        private System.Windows.Forms.ComboBox prod;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameInput;
    }
}
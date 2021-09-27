
namespace MegaDesk
{
    partial class DisplayQuote
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
            this.drawerLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.woodTypes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.widthValue = new System.Windows.Forms.Label();
            this.MaterialValue = new System.Windows.Forms.Label();
            this.depthValue = new System.Windows.Forms.Label();
            this.drawersValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // drawerLabel
            // 
            this.drawerLabel.AutoSize = true;
            this.drawerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerLabel.Location = new System.Drawing.Point(222, 320);
            this.drawerLabel.Name = "drawerLabel";
            this.drawerLabel.Size = new System.Drawing.Size(178, 24);
            this.drawerLabel.TabIndex = 15;
            this.drawerLabel.Text = "Number of Drawers:";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(273, 257);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(70, 24);
            this.depthLabel.TabIndex = 14;
            this.depthLabel.Text = "Depth: ";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(273, 194);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(68, 24);
            this.widthLabel.TabIndex = 13;
            this.widthLabel.Text = "Width: ";
            this.widthLabel.Click += new System.EventHandler(this.widthLabel_Click);
            // 
            // woodTypes
            // 
            this.woodTypes.AutoSize = true;
            this.woodTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.woodTypes.Location = new System.Drawing.Point(242, 131);
            this.woodTypes.Name = "woodTypes";
            this.woodTypes.Size = new System.Drawing.Size(133, 24);
            this.woodTypes.TabIndex = 12;
            this.woodTypes.Text = "Material Type: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Your Desk:";
            // 
            // widthValue
            // 
            this.widthValue.AutoSize = true;
            this.widthValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthValue.Location = new System.Drawing.Point(452, 194);
            this.widthValue.Name = "widthValue";
            this.widthValue.Size = new System.Drawing.Size(68, 24);
            this.widthValue.TabIndex = 16;
            this.widthValue.Text = "Width: ";
            // 
            // MaterialValue
            // 
            this.MaterialValue.AutoSize = true;
            this.MaterialValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialValue.Location = new System.Drawing.Point(452, 131);
            this.MaterialValue.Name = "MaterialValue";
            this.MaterialValue.Size = new System.Drawing.Size(68, 24);
            this.MaterialValue.TabIndex = 17;
            this.MaterialValue.Text = "Width: ";
            // 
            // depthValue
            // 
            this.depthValue.AutoSize = true;
            this.depthValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthValue.Location = new System.Drawing.Point(452, 257);
            this.depthValue.Name = "depthValue";
            this.depthValue.Size = new System.Drawing.Size(68, 24);
            this.depthValue.TabIndex = 18;
            this.depthValue.Text = "Width: ";
            // 
            // drawersValue
            // 
            this.drawersValue.AutoSize = true;
            this.drawersValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawersValue.Location = new System.Drawing.Point(452, 320);
            this.drawersValue.Name = "drawersValue";
            this.drawersValue.Size = new System.Drawing.Size(68, 24);
            this.drawersValue.TabIndex = 19;
            this.drawersValue.Text = "Width: ";
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drawersValue);
            this.Controls.Add(this.depthValue);
            this.Controls.Add(this.MaterialValue);
            this.Controls.Add(this.widthValue);
            this.Controls.Add(this.drawerLabel);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.woodTypes);
            this.Controls.Add(this.label2);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.Load += new System.EventHandler(this.DisplayQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label drawerLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label woodTypes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label widthValue;
        private System.Windows.Forms.Label MaterialValue;
        private System.Windows.Forms.Label depthValue;
        private System.Windows.Forms.Label drawersValue;
    }
}
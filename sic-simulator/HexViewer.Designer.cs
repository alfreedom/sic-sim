namespace sic_simulator
{
    partial class HexViewer
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
            this.hexBoxMem = new Be.Windows.Forms.HexBox();
            this.SuspendLayout();
            // 
            // hexBoxMem
            // 
            this.hexBoxMem.BackColorDisabled = System.Drawing.Color.Maroon;
            this.hexBoxMem.ColumnInfoVisible = true;
            this.hexBoxMem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hexBoxMem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.hexBoxMem.GroupSeparatorVisible = true;
            this.hexBoxMem.GroupSize = 1;
            this.hexBoxMem.InfoForeColor = System.Drawing.Color.Blue;
            this.hexBoxMem.LineInfoVisible = true;
            this.hexBoxMem.Location = new System.Drawing.Point(0, 0);
            this.hexBoxMem.Name = "hexBoxMem";
            this.hexBoxMem.ReadOnly = true;
            this.hexBoxMem.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexBoxMem.Size = new System.Drawing.Size(722, 261);
            this.hexBoxMem.StringViewVisible = true;
            this.hexBoxMem.TabIndex = 1;
            this.hexBoxMem.UseFixedBytesPerLine = true;
            this.hexBoxMem.VScrollBarVisible = true;
            // 
            // HexViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 261);
            this.Controls.Add(this.hexBoxMem);
            this.MaximumSize = new System.Drawing.Size(738, 600);
            this.MinimumSize = new System.Drawing.Size(738, 300);
            this.Name = "HexViewer";
            this.Text = "Mapa de memoria SIC";
            this.Load += new System.EventHandler(this.HexViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Be.Windows.Forms.HexBox hexBoxMem;
    }
}
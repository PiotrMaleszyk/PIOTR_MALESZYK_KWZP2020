namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ckB_wl_wyl = new System.Windows.Forms.CheckBox();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.btn_change_me = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ckB_wl_wyl
            // 
            this.ckB_wl_wyl.AutoSize = true;
            this.ckB_wl_wyl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ckB_wl_wyl.Location = new System.Drawing.Point(142, 179);
            this.ckB_wl_wyl.Name = "ckB_wl_wyl";
            this.ckB_wl_wyl.Size = new System.Drawing.Size(275, 33);
            this.ckB_wl_wyl.TabIndex = 0;
            this.ckB_wl_wyl.Text = "Włącz/wyłącz przycisk";
            this.ckB_wl_wyl.UseVisualStyleBackColor = true;
            this.ckB_wl_wyl.CheckedChanged += new System.EventHandler(this.ckB_wl_wyl_CheckedChanged);
            // 
            // Txt1
            // 
            this.Txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Txt1.Location = new System.Drawing.Point(21, 107);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(505, 45);
            this.Txt1.TabIndex = 1;
            this.Txt1.TextChanged += new System.EventHandler(this.Txt1_TextChanged);
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl1.Location = new System.Drawing.Point(107, 38);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(337, 36);
            this.Lbl1.TabIndex = 2;
            this.Lbl1.Text = "Laboratoria KWZP 2020";
            // 
            // btn_change_me
            // 
            this.btn_change_me.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_change_me.Location = new System.Drawing.Point(128, 243);
            this.btn_change_me.Name = "btn_change_me";
            this.btn_change_me.Size = new System.Drawing.Size(289, 64);
            this.btn_change_me.TabIndex = 3;
            this.btn_change_me.Text = "Change Me";
            this.btn_change_me.UseVisualStyleBackColor = true;
            this.btn_change_me.Click += new System.EventHandler(this.btn_change_me_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 343);
            this.Controls.Add(this.btn_change_me);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.ckB_wl_wyl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TextChanged += new System.EventHandler(this.Form1_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckB_wl_wyl;
        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Button btn_change_me;
    }
}


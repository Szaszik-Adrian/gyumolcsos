namespace gui
{
    partial class Form1
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
            this.dgvFruits = new System.Windows.Forms.DataGridView();
            this.txtNev = new System.Windows.Forms.TextBox();
            this.txtNevEng = new System.Windows.Forms.TextBox();
            this.txtMegjegyzes = new System.Windows.Forms.TextBox();
            this.txtAltSzoveg = new System.Windows.Forms.TextBox();
            this.txtSrc = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFruits)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFruits
            // 
            this.dgvFruits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFruits.Location = new System.Drawing.Point(24, 18);
            this.dgvFruits.Name = "dgvFruits";
            this.dgvFruits.Size = new System.Drawing.Size(202, 380);
            this.dgvFruits.TabIndex = 0;
            // 
            // txtNev
            // 
            this.txtNev.Location = new System.Drawing.Point(270, 21);
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(201, 20);
            this.txtNev.TabIndex = 1;
            this.txtNev.TextChanged += new System.EventHandler(this.txtNev_TextChanged);
            // 
            // txtNevEng
            // 
            this.txtNevEng.Location = new System.Drawing.Point(270, 73);
            this.txtNevEng.Name = "txtNevEng";
            this.txtNevEng.Size = new System.Drawing.Size(201, 20);
            this.txtNevEng.TabIndex = 1;
            // 
            // txtMegjegyzes
            // 
            this.txtMegjegyzes.Location = new System.Drawing.Point(270, 47);
            this.txtMegjegyzes.Name = "txtMegjegyzes";
            this.txtMegjegyzes.Size = new System.Drawing.Size(201, 20);
            this.txtMegjegyzes.TabIndex = 1;
            this.txtMegjegyzes.TextChanged += new System.EventHandler(this.txtMegjegyzes_TextChanged);
            // 
            // txtAltSzoveg
            // 
            this.txtAltSzoveg.Location = new System.Drawing.Point(270, 99);
            this.txtAltSzoveg.Name = "txtAltSzoveg";
            this.txtAltSzoveg.Size = new System.Drawing.Size(201, 20);
            this.txtAltSzoveg.TabIndex = 1;
            // 
            // txtSrc
            // 
            this.txtSrc.Location = new System.Drawing.Point(270, 125);
            this.txtSrc.Name = "txtSrc";
            this.txtSrc.Size = new System.Drawing.Size(201, 20);
            this.txtSrc.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(577, 29);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(168, 70);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "button1";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(576, 139);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 69);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "button2";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(576, 230);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(167, 68);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "button3";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(577, 334);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 64);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "button3";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtSrc);
            this.Controls.Add(this.txtAltSzoveg);
            this.Controls.Add(this.txtMegjegyzes);
            this.Controls.Add(this.txtNevEng);
            this.Controls.Add(this.txtNev);
            this.Controls.Add(this.dgvFruits);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFruits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFruits;
        private System.Windows.Forms.TextBox txtNev;
        private System.Windows.Forms.TextBox txtNevEng;
        private System.Windows.Forms.TextBox txtMegjegyzes;
        private System.Windows.Forms.TextBox txtAltSzoveg;
        private System.Windows.Forms.TextBox txtSrc;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}


namespace HumaneSocietyFormApp
{
    partial class AnimalSearch
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
            this.btnSearchAnimal = new System.Windows.Forms.Button();
            this.lblAnimalName = new System.Windows.Forms.Label();
            this.txtAnimalName = new System.Windows.Forms.TextBox();
            this.listBoxAnimalResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSearchAnimal
            // 
            this.btnSearchAnimal.Location = new System.Drawing.Point(84, 133);
            this.btnSearchAnimal.Name = "btnSearchAnimal";
            this.btnSearchAnimal.Size = new System.Drawing.Size(151, 23);
            this.btnSearchAnimal.TabIndex = 32;
            this.btnSearchAnimal.Text = "Search Animal by Name";
            this.btnSearchAnimal.UseVisualStyleBackColor = true;
            this.btnSearchAnimal.Click += new System.EventHandler(this.btnSearchAnimal_Click);
            // 
            // lblAnimalName
            // 
            this.lblAnimalName.AutoSize = true;
            this.lblAnimalName.Location = new System.Drawing.Point(37, 89);
            this.lblAnimalName.Name = "lblAnimalName";
            this.lblAnimalName.Size = new System.Drawing.Size(69, 13);
            this.lblAnimalName.TabIndex = 21;
            this.lblAnimalName.Text = "Animal Name";
            // 
            // txtAnimalName
            // 
            this.txtAnimalName.Location = new System.Drawing.Point(135, 86);
            this.txtAnimalName.Name = "txtAnimalName";
            this.txtAnimalName.Size = new System.Drawing.Size(100, 20);
            this.txtAnimalName.TabIndex = 20;
            // 
            // listBoxAnimalResult
            // 
            this.listBoxAnimalResult.FormattingEnabled = true;
            this.listBoxAnimalResult.Location = new System.Drawing.Point(353, 28);
            this.listBoxAnimalResult.Name = "listBoxAnimalResult";
            this.listBoxAnimalResult.Size = new System.Drawing.Size(476, 264);
            this.listBoxAnimalResult.TabIndex = 33;
            // 
            // AnimalSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 323);
            this.Controls.Add(this.listBoxAnimalResult);
            this.Controls.Add(this.btnSearchAnimal);
            this.Controls.Add(this.lblAnimalName);
            this.Controls.Add(this.txtAnimalName);
            this.Name = "AnimalSearch";
            this.Text = "AnimalSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearchAnimal;
        private System.Windows.Forms.Label lblAnimalName;
        private System.Windows.Forms.TextBox txtAnimalName;
        private System.Windows.Forms.ListBox listBoxAnimalResult;
    }
}
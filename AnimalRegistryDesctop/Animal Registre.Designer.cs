using System;

namespace AnimalRegistryDesctop
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Dog",
            "Laika",
            "2022-07-15",
            "Gav gav",
            "Jump",
            "Wag your tail"}, -1);
            this.button_LoadAnimal = new System.Windows.Forms.Button();
            this.button_UpdateAnimal = new System.Windows.Forms.Button();
            this.button_GetAnimal = new System.Windows.Forms.Button();
            this.button_DeletAnimal = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button_LoadAnimal
            // 
            this.button_LoadAnimal.Location = new System.Drawing.Point(1117, 52);
            this.button_LoadAnimal.Name = "button_LoadAnimal";
            this.button_LoadAnimal.Size = new System.Drawing.Size(204, 23);
            this.button_LoadAnimal.TabIndex = 0;
            this.button_LoadAnimal.Text = "Загрузить данные";
            this.button_LoadAnimal.UseVisualStyleBackColor = true;
            this.button_LoadAnimal.Click += new System.EventHandler(this.button_loadAnimal_Click);
            // 
            // button_UpdateAnimal
            // 
            this.button_UpdateAnimal.Location = new System.Drawing.Point(1117, 81);
            this.button_UpdateAnimal.Name = "button_UpdateAnimal";
            this.button_UpdateAnimal.Size = new System.Drawing.Size(204, 23);
            this.button_UpdateAnimal.TabIndex = 1;
            this.button_UpdateAnimal.Text = "Обновить информацию";
            this.button_UpdateAnimal.UseVisualStyleBackColor = true;
            this.button_UpdateAnimal.Click += new System.EventHandler(this.button_UpdateAnimal_Click);
            // 
            // button_GetAnimal
            // 
            this.button_GetAnimal.Location = new System.Drawing.Point(1117, 110);
            this.button_GetAnimal.Name = "button_GetAnimal";
            this.button_GetAnimal.Size = new System.Drawing.Size(204, 23);
            this.button_GetAnimal.TabIndex = 2;
            this.button_GetAnimal.Text = "Изменить данные";
            this.button_GetAnimal.UseVisualStyleBackColor = true;
            this.button_GetAnimal.Click += new System.EventHandler(this.button_GetAnimal_Click);
            // 
            // button_DeletAnimal
            // 
            this.button_DeletAnimal.Location = new System.Drawing.Point(1117, 139);
            this.button_DeletAnimal.Name = "button_DeletAnimal";
            this.button_DeletAnimal.Size = new System.Drawing.Size(204, 23);
            this.button_DeletAnimal.TabIndex = 3;
            this.button_DeletAnimal.Text = "Удалить строку";
            this.button_DeletAnimal.UseVisualStyleBackColor = true;
            this.button_DeletAnimal.Click += new System.EventHandler(this.button_DeletAnimal_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(21, 52);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1079, 553);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Animal Id";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Class Name";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Animal Name";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Day of Birth";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Executable command";
            this.columnHeader5.Width = 227;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Additional command";
            this.columnHeader6.Width = 169;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Additional command too";
            this.columnHeader7.Width = 223;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1344, 631);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_DeletAnimal);
            this.Controls.Add(this.button_GetAnimal);
            this.Controls.Add(this.button_UpdateAnimal);
            this.Controls.Add(this.button_LoadAnimal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(1360, 670);
            this.MinimumSize = new System.Drawing.Size(1360, 670);
            this.Name = "Form1";
            this.Text = "Реестр животных";
            this.ResumeLayout(false);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button button_LoadAnimal;
        private System.Windows.Forms.Button button_UpdateAnimal;
        private System.Windows.Forms.Button button_GetAnimal;
        private System.Windows.Forms.Button button_DeletAnimal;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}


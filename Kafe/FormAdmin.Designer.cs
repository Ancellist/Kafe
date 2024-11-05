
namespace Kafe
{
    partial class FormAdmin
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
            this.buttonRegNewUser = new System.Windows.Forms.Button();
            this.buttonWatchAllOrders = new System.Windows.Forms.Button();
            this.buttonAppointmentToReplacement = new System.Windows.Forms.Button();
            this.dataGridViewWorkers = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxUpdate = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkers)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRegNewUser
            // 
            this.buttonRegNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(198)))), ((int)(((byte)(108)))));
            this.buttonRegNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegNewUser.Location = new System.Drawing.Point(569, 65);
            this.buttonRegNewUser.Name = "buttonRegNewUser";
            this.buttonRegNewUser.Size = new System.Drawing.Size(219, 90);
            this.buttonRegNewUser.TabIndex = 1;
            this.buttonRegNewUser.Text = "Регистрация нового пользователя";
            this.buttonRegNewUser.UseVisualStyleBackColor = false;
            this.buttonRegNewUser.Click += new System.EventHandler(this.buttonRegNewUser_Click);
            // 
            // buttonWatchAllOrders
            // 
            this.buttonWatchAllOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(198)))), ((int)(((byte)(108)))));
            this.buttonWatchAllOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWatchAllOrders.Location = new System.Drawing.Point(569, 170);
            this.buttonWatchAllOrders.Name = "buttonWatchAllOrders";
            this.buttonWatchAllOrders.Size = new System.Drawing.Size(219, 90);
            this.buttonWatchAllOrders.TabIndex = 2;
            this.buttonWatchAllOrders.Text = "Просмотр заказов";
            this.buttonWatchAllOrders.UseVisualStyleBackColor = false;
            this.buttonWatchAllOrders.Click += new System.EventHandler(this.buttonWatchAllOrders_Click);
            this.buttonWatchAllOrders.MouseLeave += new System.EventHandler(this.buttonAppointmentToReplacement_MouseLeave);
            this.buttonWatchAllOrders.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonAppointmentToReplacement_MouseMove);
            // 
            // buttonAppointmentToReplacement
            // 
            this.buttonAppointmentToReplacement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(198)))), ((int)(((byte)(108)))));
            this.buttonAppointmentToReplacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAppointmentToReplacement.Location = new System.Drawing.Point(569, 275);
            this.buttonAppointmentToReplacement.Name = "buttonAppointmentToReplacement";
            this.buttonAppointmentToReplacement.Size = new System.Drawing.Size(219, 90);
            this.buttonAppointmentToReplacement.TabIndex = 3;
            this.buttonAppointmentToReplacement.Text = "Назначение на смену";
            this.buttonAppointmentToReplacement.UseVisualStyleBackColor = false;
            this.buttonAppointmentToReplacement.Click += new System.EventHandler(this.buttonAppointmentToReplacement_Click);
            this.buttonAppointmentToReplacement.MouseLeave += new System.EventHandler(this.buttonAppointmentToReplacement_MouseLeave);
            this.buttonAppointmentToReplacement.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonAppointmentToReplacement_MouseMove);
            // 
            // dataGridViewWorkers
            // 
            this.dataGridViewWorkers.AllowUserToAddRows = false;
            this.dataGridViewWorkers.AllowUserToDeleteRows = false;
            this.dataGridViewWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkers.Location = new System.Drawing.Point(10, 65);
            this.dataGridViewWorkers.Name = "dataGridViewWorkers";
            this.dataGridViewWorkers.ReadOnly = true;
            this.dataGridViewWorkers.Size = new System.Drawing.Size(553, 373);
            this.dataGridViewWorkers.TabIndex = 5;
            this.dataGridViewWorkers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWorkers_CellContentClick);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(198)))), ((int)(((byte)(108)))));
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(569, 371);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(219, 67);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.MouseLeave += new System.EventHandler(this.buttonExit_MouseLeave);
            this.buttonExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonExit_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Администратор";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(198)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.pictureBoxUpdate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 59);
            this.panel1.TabIndex = 4;
            // 
            // pictureBoxUpdate
            // 
            this.pictureBoxUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxUpdate.Image = global::Kafe.Properties.Resources._134221_refresh_reload_repeat_update_arrow_icon;
            this.pictureBoxUpdate.Location = new System.Drawing.Point(721, 6);
            this.pictureBoxUpdate.Name = "pictureBoxUpdate";
            this.pictureBoxUpdate.Size = new System.Drawing.Size(67, 50);
            this.pictureBoxUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUpdate.TabIndex = 2;
            this.pictureBoxUpdate.TabStop = false;
            this.pictureBoxUpdate.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dataGridViewWorkers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAppointmentToReplacement);
            this.Controls.Add(this.buttonWatchAllOrders);
            this.Controls.Add(this.buttonRegNewUser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdmin_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonRegNewUser;
        private System.Windows.Forms.Button buttonWatchAllOrders;
        private System.Windows.Forms.Button buttonAppointmentToReplacement;
        private System.Windows.Forms.DataGridView dataGridViewWorkers;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxUpdate;
        private System.Windows.Forms.Panel panel1;
    }
}